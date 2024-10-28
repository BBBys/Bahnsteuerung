/**
 * @file MHNeop.cpp
 * @brief Lichterkette für Musikhaus
 * @version 1.1
 * @date 28 27 9 Okt 2024 14 4 3 Okt 29 28 Sep 2023
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
      pixels.show(); // Send the updated pixel colors to the hardware.
      Unterzst = zu1;
      break;
   case zu1:
      pixels.setPixelColor(10, pixels.Color(255, 255, 255));
      pixels.show(); // Send the updated pixel colors to the hardware.
      Unterzst = zu2;
      break;
   case zu2:
      pixels.setPixelColor(4, pixels.Color(255, 255, 255));
      pixels.show();
      Unterzst = zu3;
      break;
   case zu3:
      pixels.setPixelColor(7, pixels.Color(255, 255, 255));
      pixels.show(); // Send the updated pixel colors to the hardware.
      Unterzst = zuEnde;
      Zustand = zuEnde;
   default:
      break;
   }
   Warte(random(1, 3));
}
/// @brief um 15 Uhr beginnt das Programm, 
/// zuerst mit einer Wartezeit von 5 bis 10 Minuten
void um15()
{
   log_d("um15");
   Warte(random(BASISDELAY, BASISDELAY * 2));
   Unterzst = zuIni;
   Zustand = zu151;
}
/// @brief 19 Uhr: Wartezeit 5 bis 10 Minuten
void um19()
{
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
   static bool strobo= true;
   /// so viele Sek warten
   unsigned static int i10;
   static HueFarben_t hue1[HUE1s] =
       {HUECYAN, HUEGELB, HUEGRUEN, HUEMAGENTA, HUEROT2};
   if (!Warte())
      return;
   switch (Unterzst)
   {
   case zuIni: // erst mal bunt
      log_d("Rainbow");
      pixels.rainbow(hue);
      pixels.show(); // Send the updated pixel colors to the hardware.
      Warte(3);
      if (i10++ < 30)
      {
         hue += HUE6TEL;
         return; // unschön, aber so geht es schneller
      }
      Unterzst = zu1;
      break;
   case zu1: // mehrmals 10 Sek Farbe
      log_d("2 sek Farbe");
      hue = hue1[random(0, HUE1s)];
      pixels.fill(pixels.ColorHSV(hue), 0, 12);
      Warte(10);
      pixels.show();
      if (i10++ < 15)
         return; // unschön, aber so geht es schneller
      break;
   case zu2: // Strobo
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
   }
   // so gehts weiter:
   i10 = 0;
   switch (random(0, 2))
   {
   case 0:
      Unterzst = zuIni;
      break;
   case 1:
      Unterzst = zu1;
      break;
   case 3:
      Unterzst = zu2;
      break;
   default:
      Unterzst = zuIni;
      break;
   }
}
/// @brief um 15 Uhr beginnt das Farbenspiel mit wechselnden Farben,
/// Farbwechsel so alle 1...2 Minuten, die Farben werden in zufälligen
/// Abständen durch den ganzen Farbkreis gewählt
void um151()
{
   unsigned static int hue;
   if (!Warte())
      return;
   log_d("um 151 u=%d", Unterzst);
   switch (Unterzst)
   {
   case zuIni:
      pixels.rainbow();
      // .setPixelColor(10, pixels.Color(255, 255, 255));
      pixels.show(); // Send the updated pixel colors to the hardware.
      Unterzst = zu1;
      // Zeit 1 bis 2 Min
      Warte(random(BASISDELAY / 5, BASISDELAY / 3 + 120));
      hue = random(0, 65535);
      break;
   case zu1:
      hue += random(0, 3222);
      pixels.fill(pixels.ColorHSV(hue), 0, 12);
      // Zeit 120 bis 205 Sek
      Warte(random(BASISDELAY / 5, BASISDELAY / 3 + 5));
      pixels.show();
      break;
   }}
   /// @brief um 22 Uhr ruhig und wenige Wechsel
   void um22()
   {
      unsigned static int hue;
      if (!Warte())         return;
switch (random(3))
{
case 0:   hue = HUEGRUEN;   break;
case 1:   hue = HUEBLAU;   break;
case 2:default:   hue = HUEMAGENTA;   break;
}
log_d("22 Uhr %d", hue);
pixels.fill(pixels.ColorHSV(hue), 0, 12);
// Zeit 120 bis 205 Sek
Warte(random(BASISDELAY / 5, BASISDELAY / 3 + 5));
pixels.show();
      }
   