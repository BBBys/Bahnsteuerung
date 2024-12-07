/**
 * @file MHNeop.cpp
 * @brief Lichterkette für Musikhaus
 * @version 1.1
 * @date 7 Dez 29 28 27 9 Okt 2024 14 4 3 Okt 29 28 Sep 2023
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2023-2024 B. Borys
 */
#include "musikhaus.h"
extern tZustande Zustand, Unterzst;
Adafruit_NeoPixel pixels(iNUMPIXELS, NEOPIXELPIN, NEO_GRB + NEO_KHZ800);
// Adafruit_NeoPixel pixels(iNUMPIXELS, NEOPIXELPIN,);
#define DELAYVAL 500 // Time (in milliseconds) to pause between pixels
void um0()
{
   log_d("0 Uhr Rücksetzen");
   pixels.clear(); // Set all pixel colors to 'off'
   pixels.show();  // Send the updated pixel colors to the hardware.
   Grillfeuer.aus();
   Eingangstafel.aus;
}
/// @brief um 12 Uhr beginnt das Programm
/// Vorbereitung
void um12()
{
   log_d("12 Uhr");
   pixels.clear(); // Set all pixel colors to 'off'
   pixels.show();  // Send the updated pixel colors to the hardware.
   Warte(random(BASISDELAY, BASISDELAY * 3));
   Unterzst = zuIni;
   Zustand = zu121;
}
/// @brief um 12 Uhr gehen nacheinander 4 weiße Lampen an
void um121()
{
   log_d("um 12.1");
   if (!Warte())
      return;
   switch (Unterzst)
   {
   case zuIni:
      pixels.setPixelColor(1, pixels.Color(255, 255, 255));
      Unterzst = zu1;
      break;
   case zu1:
      pixels.setPixelColor(10, pixels.Color(255, 255, 255));
      Unterzst = zu2;
      break;
   case zu2:
      pixels.setPixelColor(4, pixels.Color(255, 255, 255));
      Unterzst = zu3;
      break;
   case zu3:
      pixels.setPixelColor(7, pixels.Color(255, 255, 255));
      Unterzst = zuEnde;
      Zustand = zuEnde;
      break;
   default:
      break;
   }
   pixels.show(); // Send the updated pixel colors to the hardware.

   Warte(random(1, 3));
}
/// @brief um 15 Uhr beginnt das Programm,
/// zuerst mit einer Wartezeit von 5 bis 10 Minuten
void um15()
{
   Grillfeuer.ein();
   log_d("um15");
   Warte(random(BASISDELAY, BASISDELAY * 2));
   Unterzst = zuIni;
   Zustand = zu151;
}
/// @brief 19 Uhr: Wartezeit 5 bis 10 Minuten
void um19()
{
   Grillfeuer.ein();
   Eingangstafel.ein();
   pixels.setPixelColor(1, pixels.Color(255, 0, 255));
   pixels.setPixelColor(4, pixels.Color(255, 255, 0));
   pixels.setPixelColor(7, pixels.Color(0, 255, 255));
   pixels.setPixelColor(10, pixels.Color(255, 128, 128));
   pixels.show(); // Send the updated pixel colors to the hardware.
   Warte(random(BASISDELAY, BASISDELAY * 2));
   Unterzst = zuIni;
   Zustand = zu191;
}
void um191()
{
   const static unsigned int HUE1s = 5;
   unsigned static int hue = 0;
   // static bool strobo= true;
   /// so viele Sek warten
   unsigned static int i10 = 0;
   static HueFarben_t hue1[HUE1s] =
       {HUECYAN, HUEGELB, HUEGRUEN, HUEMAGENTA, HUEROT2};
   if (!Warte())
      return;
   Grillfeuer.loop();
   switch (Unterzst)
   {
   case zuIni: // erst mal bunt
      log_d("Rainbow");
      pixels.rainbow(hue);
      Warte(3);
      if (i10++ < 30){hue += HUE6TEL;return;}
      Unterzst = zu1;
      break;
   case zu1: // mehrmals 10 Sek Farbe
      log_d("10 sek Farbe");
      hue = hue1[random(0, HUE1s)];
      pixels.fill(pixels.ColorHSV(hue), 0, 12);
      Warte(10);
      if (++i10 < 15)
         return;
      Unterzst = zu2;
      break;
   case zu2:
      log_d("Strobo");
      for (size_t i = 0; i < 25; i++)
      {
         pixels.fill(pixels.Color(255, 255, 255), 0, 12);
         pixels.show();
         delay(25);
         pixels.clear();
         pixels.show();
         delay(66);
      }
      i10 = 0;
      Unterzst = (random(0, 3) == 2) ? zu2 : (random(0, 2) == 1) ? zu1
                                                                 : zuIni;
      break;
   }
   pixels.show();
}
/// @brief um 15 Uhr beginnt das Farbenspiel mit wechselnden Farben,
/// Farbwechsel so alle 1...2 Minuten, die Farben werden in zufälligen
/// Abständen durch den ganzen Farbkreis gewählt
void um151()
{
   unsigned static int hue;
   if (!Warte())
      return;
   Grillfeuer.loop();
   log_d("um 151 u=%d", Unterzst);
   switch (Unterzst)
   {
   case zuIni:
      pixels.rainbow();
      // .setPixelColor(10, pixels.Color(255, 255, 255));
      // pixels.show(); // Send the updated pixel colors to the hardware.
      // Zeit 1 bis 2 Min
      Warte(random(BASISDELAY / 5, BASISDELAY / 3 + 120));
      hue = random(0, 65535);
      Unterzst = zu1;
      break;
   case zu1:
      hue += random(0, 3222);
      pixels.fill(pixels.ColorHSV(hue), 0, 12);
      // Zeit 120 bis 205 Sek
      Warte(random(BASISDELAY / 5, BASISDELAY / 3 + 5));
      break;
   }
   pixels.show();
}
/// @brief um 22 Uhr ruhig und wenige Wechsel
void um22()
{
   static unsigned int hue;
   if (!Warte())
      return;
   Grillfeuer.aus();
   hue = (random(3) == 2) ? HUEMAGENTA : (random(2) == 1) ? HUEBLAU
                                                          : HUEGRUEN;
   log_d("22 Uhr %d", hue);
   pixels.fill(pixels.ColorHSV(hue), 0, 12);
   Warte(random(BASISDELAY / 5, BASISDELAY / 3 + 5));
   pixels.show();
}