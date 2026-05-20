#ifndef BHFANZ_H
#define BHFANZ_H
#include <Arduino.h>
#include "Adafruit_SSD1306.h" //< nicht das Original, sondern von heltec.cn
enum anz_t
{
    anzStart,
    anzUhr,anzText,anzZug,
    anzEnde
};
bool initWiFi();
void zifferblatt(Adafruit_SSD1306 display, int x0, int y0, int r);
void stdzeiger(Adafruit_SSD1306 display, int x0, int y0, int r, int std, int mn);
void minzeiger(Adafruit_SSD1306 display, int x0, int y0, int r, int mn,bool sec=false);
void UhrAnzeige(Adafruit_SSD1306 display);
bool ZugAnzeige(Adafruit_SSD1306 display);
void TextAnzeige(Adafruit_SSD1306 display);
#endif