#include "Audio.h"
#include "SD.h"
#include "FS.h"
#include <vector>
#define I2S_LRC 25
#define I2S_DOUT 26
#define I2S_BCLK 5
#define SD_CS 2
#define SPI_MOSI 23
#define SPI_MISO 19
#define SPI_SCK 18
#define PIR_PIN 4
    Audio audio;
std::vector<String> mp3Files;
volatile bool playAudio = false;
void IRAM_ATTR onMotionDetected()
{
    playAudio = true;
}
void audiosetup()
{
    Serial.begin(115200);
    // Initialize PIR sensor
    pinMode(PIR_PIN, INPUT);
    attachInterrupt(digitalPinToInterrupt(PIR_PIN), onMotionDetected, RISING);
    // Initialize SPI bus for SD card
    SPI.begin(SPI_SCK, SPI_MISO, SPI_MOSI);
    if (!SD.begin(SD_CS))
    {
        Serial.println("SD Card Mount Failed");
        return;
    }
    Serial.println("SD Card initialized.");
    // Set up the I2S audio output
    audio.setPinout(I2S_BCLK, I2S_LRC, I2S_DOUT);
    audio.setVolume(17); // Volume level: 0 (mute) to 21 (max)
    // List MP3 files in the root directory
    File root = SD.open("/");
    File file = root.openNextFile();
    while (file)
    {
        if (!file.isDirectory() && String(file.name()).endsWith(".mp3"))
        {
            mp3Files.push_back(String(file.name()));
            Serial.println("Found MP3: " + String(file.name()));
        }
        file = root.openNextFile();
    }
    Serial.printf("Total MP3 files found: %d\n", mp3Files.size());
}
void audioloop()
{
    // Check if the PIR sensor was triggered
    if (playAudio && mp3Files.size() > 0)
    {
        playAudio = false; // Reset the flag
        // Select a random MP3 file from the list
        int randomIndex = random(0, mp3Files.size());
        String selectedFile = mp3Files[randomIndex];
        Serial.println("Playing MP3: " + selectedFile);
        if (!audio.connecttoFS(SD, ("/" + selectedFile).c_str()))
        {
            Serial.println("Failed to start MP3 playback");
        }
    }
    // Handle the audio playback
    audio.loop();
}