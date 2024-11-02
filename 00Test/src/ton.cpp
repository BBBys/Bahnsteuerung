/**
 * @file Ton.cpp
 * @brief Test Audio-Ausgabe
 * basiert auf Echo Trap von AZ-Delivery und https://github.com/schreibfaul1/ESP32-audioI2S
 * @version 1.1
 * @date 2 Nov 2024
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024  B. Borys
 */
#include <Arduino.h>
#include "test.h"
#include "Audio.h"
//#include "FS.h"
#include <vector>

#define I2S_LRC 12
//26
#define I2S_DOUT 14
//25
#define I2S_BCLK 27

void listDir(fs::FS &fs, const char *dirname, uint8_t levels); // proto
Audio audio;
File dir;
std::vector<char *> v_audioContent;
const char audioDir[] = "/";
void listDir(fs::FS &fs, const char *dirname, uint8_t levels)
{
    Serial.printf("Listing directory: %s\n", dirname);

    File root = fs.open(dirname);
    if (!root)
    {
        Serial.println("Failed to open directory");
        return;
    }
    if (!root.isDirectory())
    {
        Serial.println("Not a directory");
        return;
    }

    File file = root.openNextFile();
    while (file)
    {
        if (file.isDirectory())
        {
            Serial.print("  DIR : ");
            Serial.println(file.name());
            if (levels)
            {
                listDir(fs, file.path(), levels - 1);
            }
        }
        else
        {
            Serial.print("  FILE: ");
            Serial.print(file.name());
            Serial.print("  SIZE: ");
            Serial.println(file.size());
            v_audioContent.insert(v_audioContent.begin(), strdup(file.path()));
        }
        file = root.openNextFile();
    }
    Serial.printf("num files %i", v_audioContent.size());
    root.close();
    file.close();
}

void tonsetup()
{
    audio.setPinout(I2S_BCLK, I2S_LRC, I2S_DOUT);
    audio.setVolume(17); // 0...21 Will need to add a volume setting in the app
    dir = SD.open(audioDir);
    listDir(SD, audioDir, 1);
    if (v_audioContent.size() > 0)
    {
        const char *s = (const char *)v_audioContent[v_audioContent.size() - 1];
        Serial.printf("playing %s\n", s);
        audio.connecttoFS(SD, s);
        v_audioContent.pop_back();
    }
}
void tonloop() { audio.loop(); }
