/**
 * @file BhfAnzMain.cpp
 * Bahnhofsanzeige
 * =========================
 * @author BBB
 * @version 1.0
 * @date 23 22 Apr 2021
 */
#include <time.h>
#include <sys/time.h>
#include <TZ.h>
#include <SPI.h>
#include <Wire.h>
#include "Adafruit_GFX.h" //< nicht das Original, sondern von heltec.cn
#include "BhfAnz.h"
/*********************************************************************
This is an example for our Monochrome OLEDs based on SSD1306 drivers

  Pick one up today in the adafruit shop!
  ------> http://www.adafruit.com/category/63_98

This example is for a 128x64 size display using I2C to communicate
3 pins are required to interface (2 I2C and one reset)

Adafruit invests time and resources providing this open source code,
please support Adafruit and open-source hardware by purchasing
products from Adafruit!

Written by Limor Fried/Ladyada  for Adafruit Industries.
BSD license, check license.txt for more information
All text above, and the splash screen must be included in any redistribution
*********************************************************************/
//#define SSD1306_128_64
/*
 * noch nicht fertig
 * 
 class Uhr {
    int H,W,R;
        float X0,Y0;
       Adafruit_SSD1306 *D;
  public: Uhr(Adafruit_SSD1306 d,int r)
    {
       H = d.height();
       W = d.width();
       R = r;
       X0 = W / 2;
       Y0 = H / 2;
       D=&d;
    };
    void zifferblatt()
    {
      D->drawCircle(X0, Y0 , R, WHITE);
      float wi = 3.1415926535898 / 6.0;
      for (int i = 0; i < 11.99; i++)
      { float x, y;
        x = R * sin(i * wi);
        y = R * cos(i * wi);
        D->drawLine(0.9 * x + X0, 0.9 * y + Y0, 0.8 * x + X0, 0.8 * y + Y0, WHITE);
      }
    };
};
*/
//TwoWire *tw=new TwoWire();

#define OLED_RESET -1
Adafruit_SSD1306 display(OLED_RESET);
#if (SSD1306_LCDHEIGHT != 64)
#error("Height incorrect, please fix Adafruit_SSD1306.h!");
#endif
void setup()
{
  Serial.begin(115200);
  display.begin(); //SSD1306_SWITCHCAPVCC, 0x3c); // initialize with the I2C addr 0x3D (for the 128x64) oder 3C für den weißen chinesischen
  display.clearDisplay();
  display.setTextSize(1);
  display.setTextColor(WHITE);
  display.setCursor(10, 10);
//  initWiFi();
  configTzTime(TZ_Europe_Berlin, "192.168.1.1");
}
anz_t Anzeige = anzUhr;
unsigned long Startzeit = 0;
bool istAnzeige = false;
void loop()
{

  unsigned long jetzt;
  jetzt = millis();
  if (jetzt < Startzeit) //Überlauf
    Startzeit = jetzt;
#ifndef NDEBUG
  //testdrawchar();  return;
  Anzeige = anzText;
  Serial.printf("\nAnzeige=%d",Anzeige);
#endif
  switch (Anzeige)
  {
    bool weiter;
  case anzStart:
    Startzeit = jetzt;
    Anzeige = anzUhr;
    break;

  case anzUhr:
    UhrAnzeige(display);
    if (jetzt - Startzeit > 20000)
    {
      Startzeit = jetzt;
      Anzeige = anzText;
    }
    break;

  case anzText:
    if (!istAnzeige){
      TextAnzeige(display);
      istAnzeige = true;
    }
      else if (jetzt - Startzeit > 5000)
      {
        istAnzeige = false;
        Startzeit = jetzt;
        Anzeige = anzZug;
    }
    break;

  case anzZug:

    weiter = ZugAnzeige(display);
    if (weiter)
    {
      Startzeit = jetzt;
      Anzeige = anzEnde;
    }
    break;

  default:
    Anzeige = anzStart;
    break;
  }
}
