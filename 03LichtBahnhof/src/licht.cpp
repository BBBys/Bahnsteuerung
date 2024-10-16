/**
 * @file licht.cpp
 * @brief Licht am Bahnhof
 * @version 1.1
 * @date 16 15 Okt 2024
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024  B. Borys
 */
//  #include <experimental/random>
#include <Arduino.h>
#include "licht.h"
/// @brief Verwaltung aller Lichter
Lichter::Lichter()
{
    //LichterListe = new std::vector<Licht>();
}
void Lichter::Add(Licht l)
{
    LichterListe.push_back(l);
}
void Lichter::Loop()
{
    for (Licht l : LichterListe)
    {
        l.Loop();
    }
}
Lichter::~Lichter()
{
}

Licht::Licht(int nr)
{
    Licht(nr, 60, 0);
}
void Licht::An()
{
    /*Licht einschalten, keine Zeitberechnung*/
    Fix = true;
}
void Licht::An(int an) { An(an, 0); }
void Licht::An(int an, int aus)
{
    /*noch nicht schalten, erst Zeitberechnung*/
    Fix = false;
    TAn = an << 6;
    TAus = aus << 6;
    Zeit = zeitberechnung(TAus);
    Ziel = LichtAn;
}
void Licht::Aus()
{
    /*Licht ausschalten, keine Zeitberechnung*/
    Fix = true;
}
void Licht::Aus(int aus) { Aus(0, aus); }
void Licht::Aus(int an, int aus)
{
    /*noch nicht schalten, erst Zeitberechnung*/
    Fix = false;
    TAn = an << 6;
    TAus = aus << 6;
    Zeit = zeitberechnung(TAn);
    Ziel = LichtAus;
}
/// @brief nächster Zeitpunkt in Sys-Millis
/// @param t Dauer in Sekunden
long Licht::zeitberechnung(short t)
{
    return millis() + t * 1000 + random(0, 30000) - 15000; // +/- 15 Sek
}
/// @brief ein Licht
/// @param nr seine Nummer
/// @param an Zeit an
/// @param aus Zeit aus
Licht::Licht(int nr, int an, int aus)
{
    Nr = nr;
    TAn = an << 6;
    TAus = aus << 6;
    Zeit = 0;
    Ziel = Ist = LichtAus;
    Fix = true;
}
bool Licht::erreicht()
{
    return (millis() - Zeit > 0);
}
/// @brief Licht schalten
void Licht::Loop()
{
    int t;
    if (Fix || Ziel == Ist || !erreicht())
        return;

    Ist = Ziel;
    if (Ziel == LichtAn)
    {
        An();
        t = TAn;
        Ziel = LichtAus;
    }
    else
    {
        Aus();
        t = TAus;
        Ziel = LichtAn;
    }
    Zeit = zeitberechnung(t);
}
Licht::~Licht()
{
}
