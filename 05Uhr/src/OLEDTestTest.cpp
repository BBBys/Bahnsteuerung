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
#define SSD1306_128_64
#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
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

#define OLED_RESET 4
Adafruit_SSD1306 display(OLED_RESET);

#if (SSD1306_LCDHEIGHT != 64)
#error("Height incorrect, please fix Adafruit_SSD1306.h!");
#endif
int HH = 22;
int MM = 59;
int SEC = 0;
void setup()   {
  // Serial.begin(9600);

  // by default, we'll generate the high voltage from the 3.3v line internally! (neat!)
  display.begin(SSD1306_SWITCHCAPVCC, 0x3C);  // initialize with the I2C addr 0x3D (for the 128x64)
  // init done
//Uhr uhr(display, 31);

  display.display();


}


void loop() {
  display.clearDisplay();
  float x0 = display.width() / 2;
  float y0 = display.height() / 2;
  float r = 31;
  zifferblatt(x0, y0, r);
  stdzeiger(x0, y0, r, HH, MM);
  minzeiger(x0, y0, r, MM);
  minzeiger(x0, y0, r, SEC);
  display.display();
  delay(1000);
  SEC++;
  if (SEC > 59)
  {
    SEC = 0;
    MM++;
    if (MM > 59)
    {
      MM = 0;
      HH++;
      if (HH > 23)HH = 0;
    }
  }
}
void zifferblatt(int x0, int y0, int r)
{
  display.drawCircle(x0, y0 , r, WHITE);
  float wi = 3.1415926535898 / 6.0;
  for (int i = 0; i < 11.99; i++)
  { float x, y;
    x = r * sin(i * wi);
    y = r * cos(i * wi);
    display.drawLine(0.9 * x + x0, 0.9 * y + y0, 0.8 * x + x0, 0.8 * y + y0, WHITE);
  }
}
void stdzeiger(int x0, int y0 , int r, int std, int mn)
{
  float st = (float)std + (float)mn / 60.0;
  float wi = 3.1415926535898 / 6.0;
  float x, y, f = 0.4;
  x = r * sin(st * wi);
  y = -r * cos(st * wi);
  display.drawLine( x0,  y0, f * x + x0, f * y + y0, WHITE);
}
void minzeiger(int x0, int y0 , int r, int mn)
{
  float wi = 3.1415926535898 / 30.0;
  float x, y, f = 0.7;
  x = r * sin(mn * wi);
  y = -r * cos(mn * wi);
  display.drawLine( x0,  y0, f * x + x0, f * y + y0, WHITE);
}

