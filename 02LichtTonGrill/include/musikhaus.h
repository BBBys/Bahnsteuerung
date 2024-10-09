/**
 * @file Musikhaus.h
 * @brief Musik und Partylicht in der Grillhütte
 * @version 1.1
 * @date 14 4 2 Okt 26 Sep 2023
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2023 B. Borys
 */
#ifndef MUSIKHAUS_H
#define MUSIKHAUS_H

#include <Arduino.h>
#include <EspMQTTClient.h>
#include <Adafruit_NeoPixel.h>
#include <Ticker.h> /// Load library "ticker" for blinking status led
static const u_int8_t NEOPIXELPIN = 2, iNUMPIXELS = 12;
/**
 * @brief Farben als RGB-Werte
 */
enum RGBFarben
{
    NEOROT = 0xff0000,
    NEOGELB = 0xff5F00,
    NEOGRUEN = 0x00ff00,
    NEOBLAU = 0x0000ff,
    NEOWEISS = 0xffffff
};

// #define HUEGRUEN 21845
// #define HUEBLAU 43690
// #define HUEROT 0
enum HueFarben_t
{
    HUEROT = 0,                // 65536 * 0/6
   HUE12TEL= 5462U,          // 1/6 vom Farbkreis
     HUEGELB = 10923U,          // 65536 * 1/6
    HUE6TEL= 10923U,          // 1/6 vom Farbkreis
    HUEGELBLICHGRUEN = 18204U, // 2/3 grün + 1/3 gelb
    HUEGRUEN = 21845U,         // 65536 * 2/6
    HUECYAN = 32768U,          // 65536 * 3/6
    HUEBLAU = 43691U,          // 65536 * 4/6
    HUEMAGENTA = 54613U,       // 65536 * 5/6
    HUEROT2 = 65535U,          // 65536 * 6/6
    HUEMAX = 65335U            // 65336 * 6/6
};
void cbWartezeit();
void tcbBlink(HueFarben_t pFarbton);
void flip();
void tcbLauf(HueFarben_t p);
double dmap(double x, double in_min, double in_max, double out_min, double out_max);
void AnzeigenI(uint8_t pNummer, float pTemp);
void Anzeigen2H(uint8_t pNummer, float pTempV, float pTempR);
enum tZustande
{
    zuNull = 0,
    zuIni, // Anfangszustand
    zu12,
    zu121,
    zu12e, // 12 Uhr: Putzlicht
    zu15,
    zu151, // 15 Uhr langsame Musik
    zu19,
    zu191, // Disco
    // für Unterzustände
    zu1,
    zu2,
    zu3,
    zuEnde
};
void um12();
void um121();
void um15();
void um151();
void um19();
void um191();
/**
 * Wartezeitverwaltung
 */
void Warte(unsigned long t);
bool Warte();
#endif