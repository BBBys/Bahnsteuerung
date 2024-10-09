/**
 * @file MHHilfen.cpp
 * @brief Hilfen für Müspküavillon
 * @version 1.1
 * @date 14 4 Okt 26 Sep 2023
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2023 B. Borys
 */
#include "Musikhaus.h"
uint8_t nFlip = 0, iLauf = 0;
extern uint8_t nStrips;
// https://github.com/adafruit/Adafruit_NeoPixel
extern Adafruit_NeoPixel pixels;
extern Ticker Zeitgeber;
unsigned long Wartezeit = 0;
/**
 * @brief Timer-Callback: Wartezeit abgelaufen, rotes Blinken einschalten
 *
 */
void cbWartezeit()
{
    log_w("Zeit abgelaufen");
    Zeitgeber.detach();
    Zeitgeber.attach(1, tcbBlink, HUEROT);
}

/**
 * @brief bessere Mapping-Funktion
 *
 * @param x Eingangswert im Bereich in_min...in_max
 * @param in_min
 * @param in_max
 * @param out_min
 * @param out_max
 * @return double Ausgangswert im Bereich out_min...out_max
 */
double dmap(double x, double in_min, double in_max, double out_min, double out_max)
{
    return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
}
/**
 * Wartezeit in Sekunden initialisieren
 * @param t Wartezeit in Sekunden
 */
void Warte(unsigned long t)
{
    //log_d("%uld", millis());
    Wartezeit = millis() + t * 1000L;
    //log_d("%uld", Wartezeit);
}
/**
 * Wartezeit um?
 * @returns true, wenn um
 */
bool Warte()
{
    return Wartezeit < millis();
}