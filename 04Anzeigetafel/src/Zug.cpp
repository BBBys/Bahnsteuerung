//#include "Adafruit_GFX.h" //< nicht das Original, sondern von heltec.cn
#include "BhfAnz.h"
enum
{
    fpVon,
    fpBis,
    fpMin,
    fpGleis,
    fpZiel,
    fpElemente
};
struct fpZeile
{
    uint8 von, bis, mn;
    String Gleis, Ziel, Zug;
};
const uint8 Anzahl = 5;
static const fpZeile Fahrplan[Anzahl]  = {{5, 23, 50, "Gleis 1", "G\x94ttingen", "RB 83 Cantus 8841"},
                                         {5, 23, 8, "Gleis 2", "Kassel Hbf", "RB 83 Cantus 8842"},
                                         {5, 22, 28, "Vorplatz", "Calden", "Bus 47"},
                                         {5, 22, 39, "Vorplatz", "Flughafen", "Bus 100"},
                                         {5, 22, 24, "Bus-Terminal", "Berlin", "FlixBus 123"}};

bool ZugAnzeige(Adafruit_SSD1306 display)
{
    static time_t now;
    tm *zeit;
    uint8 mn, hr;
    const uint8 LEN = 20;
    char text1[LEN], text2[LEN], text3[LEN], text4[LEN];

    now = time(nullptr);
    zeit = localtime(&now);
    mn = zeit->tm_min;
    hr = zeit->tm_hour;
#ifndef NDEBUG
    //mn = 49;
#endif
    text1[0] = 0;
    sprintf_P(text4, "%02d:%02d", hr, mn);
    for (uint8 i = 0; i < Anzahl; i++)
    {
        fpZeile zeile = Fahrplan[i];
        if (hr < zeile.von)
            continue;
        if (hr > zeile.bis)
            continue;
        if (mn < zeile.mn - 5)
            continue;
        if (mn > zeile.mn + 1)
            continue;
        sprintf_P(text1, "%02d:%02d %s", hr, zeile.mn,zeile.Gleis.c_str());
        zeile.Ziel.toCharArray(text2, LEN);
        zeile.Zug.toCharArray(text3, LEN);
        break;
    }
    if (strlen(text1) < 2)
    {
        return true;
    }
    display.clearDisplay();
    display.setTextWrap(false);
    display.setTextColor(WHITE);
    display.setCursor(0, 0);
    display.setTextSize(1);
    display.print(text1);
    display.setCursor(0, 15);
    display.setTextSize(2);
    display.println(text2);
    display.setTextSize(1);
    display.println(text3);
    display.setCursor(display.width() - 30, display.height() - 7);
    display.println(text4);
    display.display();
    return false;
}
