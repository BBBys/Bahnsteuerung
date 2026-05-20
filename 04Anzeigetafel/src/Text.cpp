//#include "Adafruit_GFX.h" //< nicht das Original, sondern von heltec.cn
#include "BhfAnz.h"
void TextAnzeige(Adafruit_SSD1306 display)
{
    int text;
    display.clearDisplay();
    text = random(4);
    Serial.printf("Text nr. %d\n", text);

    switch (text)
    {
    case 0:
        display.setTextSize(1);
        display.setTextColor(WHITE);
        display.setCursor(0, 0);
        display.println("Lassen Sie ihr");
        display.println(" ");
        display.setTextSize(2);
        display.println("Gep\x84\u0063k");
        display.setTextSize(1);
        display.println(" ");
        display.println(" nicht ");
        display.println(" unbeaufsichtigt!");
        break;

    case 1:
        display.setTextSize(1);
        display.setTextColor(WHITE);
        display.setCursor(0, 0);
        display.println("Alle redem vom");
        display.println(" ");
        display.setTextSize(2);
        display.println("Wetter");
        display.setTextSize(1);
        display.println(" ");
        display.println("   wir nicht!");
        break;

    case 2:
        display.setTextSize(2);
        display.setTextColor(WHITE);
        display.setCursor(0, 0);
        display.println("Sparen");
        display.setTextSize(1);
        display.println("\nmit der\n");
        display.setTextSize(2);
        display.println("Bahncard");
        break;

    case 3:
        display.setTextColor(WHITE);
        display.setCursor(0, 0);
        display.println("All your");
        display.setTextSize(2);
        display.println(" Base");
        display.setTextSize(1);
        display.println("\nare belong");
        display.setTextSize(2);
        display.println("   to Us");
        break;

    default:
        break;
    }

    display.display();
}

void testdrawchar(Adafruit_SSD1306 display)
{
    const uint8_t von = 130, bis = 156;
    display.clearDisplay();
    display.setTextWrap(false);
    display.setTextSize(1);
    display.setTextColor(WHITE);
    display.setCursor(0, 0);

    for (uint8_t i = von; i < bis; i++)
    {
        if (i == '\n')
            continue;
        display.write(i);
        if ((i > 0) && (i % 21 == 0))
            display.println();
    }
    display.write('\x94');
    display.display();
}
