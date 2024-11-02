/**
 * @file SDReader.cpp
 * @brief Test SD-Reader
 * basiert auf Echo Trap von AZ-Delivery
 * @version 1.1
 * @date 1 Nov 29 Okt 2024
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024  B. Borys
 */
#include <Arduino.h>
#include "test.h"
/**
 * @brief
 *
 */
// include the SD library:
#include <SPI.h>
#include <SD.h>
#include <FS.h>
#include <vector>
#define I2S_LRC 25
#define I2S_DOUT 26
#define I2S_BLCK 5
#define SD_CS 2
#define SPI_MOSI 23
#define SPI_MISO 19
#define SPI_SCK 18
std::vector<String> mp3Files;
volatile bool playAudio = false;
void IRAM_ATTR onMotionDetected()
{
    playAudio = true;
}

// change this to match your SD shield or module;
// Arduino Ethernet shield: pin 4
// Adafruit SD shields and modules: pin 10
// Sparkfun SD shield: pin 8
// MKRZero SD: SDCARD_SS_PIN
const int chipSelect = 4;

void sdsetup()
{
    // Open serial communications and wait for port to open:
    while (!Serial)
    {
        ; // wait for serial port to connect. Needed for native USB port only
    }
    SPI.begin(SPI_SCK, SPI_MISO, SPI_MOSI);
    if (!SD.begin(SD_CS))
    {
        Serial.println("SD Fehler");
        return;
    }
    log_i("SD OK");
    Serial.print("Card type:         ");
    Serial.println(SD.cardType());
    Serial.print("Size     :         ");
    Serial.println(SD.cardSize());
    Serial.print("Bytes    :         ");
    Serial.println(SD.totalBytes());
    Serial.print("KBytes   :         ");
    Serial.println((SD.totalBytes()) >> 10);
    Serial.print("MBytes   :         ");
    Serial.println((SD.totalBytes()) >> 20);
    Serial.print("GBytes   :         ");
    Serial.println((SD.totalBytes()) >> 30);

    File root = SD.open("/");
    //root.printf("hallo");
    File file = root.openNextFile();
    while (file)
    {
        if (file.isDirectory())
            log_i("Directory");
        else 
        log_i("gefunden %s", String(file.name()));
     file = root.openNextFile(); }
    log_i("gesamt ");
      log_i("%d", mp3Files.size());
}

void sdloop(void)
{
}
