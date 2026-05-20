#include "Adafruit_GFX.h" //< nicht das Original, sondern von heltec.cn
#include "BhfAnz.h"
void drawLine2(Adafruit_SSD1306 display, int x0, int y0, int x1, int y1, int cl)
{
    int dx, dy;
    display.drawLine(x0, y0, x1, y1, cl);
    dx = x1 - x0;
    dy = y1 - y0;
    if (dx<dy)
    {
        dx = 0;
        dy = 1;
    }
    else
    {
        dx = 1;
        dy = 0;
    }
    display.drawLine(x0+dy, y0+dx, x1+dy, y1+dx, cl);
    display.drawLine(x0-dy, y0-dx, x1-dy, y1-dx, cl);
}
const uint8 clFg=WHITE,clBg=BLACK;

/**
 * @brief zeichne leeres Zifferblatt
 * 
 * @param display 
 * @param x0 Mitte
 * @param y0 Mitte
 * @param r Radius
 */
void zifferblatt(Adafruit_SSD1306 display,    int x0, int y0, int r)
{
    //display.drawCircle(x0, y0, r, clBg);
    //display.drawCircle(x0, y0, r+1, clBg);
    display.fillCircle(x0, y0, r + 1, clBg);
    float wi = PI / 6.0;
    for (int i = 0; i < 11.99; i++)
    {
        float x, y;
        x = r * sin(i * wi);
        y = r * cos(i * wi);
        display.drawLine(0.9 * x + x0, 0.9 * y + y0, 0.8 * x + x0, 0.8 * y + y0, clFg);
        //drawLine2(display,0.9 * x + x0, 0.9 * y + y0, 0.8 * x + x0, 0.8 * y + y0, clFg);
    }
}


/**
 * @brief zeichne Stundenzeiger
 * 
 * @param display 
 * @param x0 Mitte
 * @param y0 Mitte
 * @param r Radius Zifferblatt
 * @param std Stunde
 * @param mn Minute
 */
void stdzeiger(Adafruit_SSD1306 display, int x0, int y0, int r, int std, int mn)
{
    float st = (float)std + (float)mn / 60.0;
    float wi = PI / 6.0;
    float x, y, f = 0.4;
    x = r * sin(st * wi);
    y = -r * cos(st * wi);
    display.drawLine(x0, y0, f * x + x0, f * y + y0, clFg);
}
/**
 * @brief zeichne Minutenzeiger, geht auch für Sekundenzeiger
 * 
 * @param display 
 * @param x0 Mitte
 * @param y0 Mitte
 * @param r Radius Zifferblatt
 * @param mn Minute
 */
void minzeiger(Adafruit_SSD1306 display, int x0, int y0, int r, int mn,bool sec)
{
    float wi = PI / 30.0;
    float x, y, f = 0.7,fs=0.45;
    x = r * sin(mn * wi);
    y = -r * cos(mn * wi);
    display.drawLine(x0, y0, f * x + x0, f * y + y0, clFg);
    if(sec)
        display.drawCircle(fs * x + x0, fs * y + y0, 2,clFg);
}
void UhrAnzeige(Adafruit_SSD1306 display)
{
    static time_t now;
    tm *zeit;
    display.clearDisplay();
    int x0 = display.width() / 2;
    int y0 = display.height() / 2;
    int r = min(x0 - 1, y0 - 1);
    zifferblatt(display, x0, y0, r);
    now = time(nullptr);
    zeit = localtime(&now);
    stdzeiger(display, x0, y0, r, zeit->tm_hour, zeit->tm_min);
    minzeiger(display, x0, y0, r, zeit->tm_min);
    minzeiger(display, x0, y0, r, zeit->tm_sec,true);
    //display.invertDisplay(true);
    display.display();
    delay(1000);
}
