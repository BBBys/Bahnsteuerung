/**
 * @file licht.cpp
 * @brief Licht am Bahnhof
 * @version 1.1
 * @date 16 15 Okt 2024
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024  B. Borys
 */
#pragma once
#include <vector>

/// @brief ein Licht
class Licht
{
private:
    /// @brief Zeit für diesen Zustand in Sekunden
    unsigned int TAn, TAus;
  unsigned  int Nr;
    /// @brief Zeitpunkt in System-Millisekunden
    long Zeit;
    bool Ziel, Ist;
    bool Fix; /// keine automatische Änderung
    const bool LichtAn = true, LichtAus = false;
    long zeitberechnung(short t);
    bool erreicht();

public:
    void Loop();
    Licht(int nr);
    Licht(int nr, int an, int aus);
    ~Licht();
    void An();
    /// @brief an nach Wartezeit
    /// @param aus Sekunden warten
    void An(int aus);
    /// @brief an nach Wartezeit, dann wieder aus
    /// @param an wieder an nach Sekunden
    /// @param aus erst Sekunden warten
    void An(int an, int aus);
    void Aus();
    /// @brief aus nach Wartezeit
    /// @param an Sekunden warten
    void Aus(int an);
    /// @brief aus nach Wartezeit, dann wieder an
    /// @param an erst Sekunden warten
    /// @param aus wieder an nach Sekunden
    void Aus(int an, int aus);
};

class Lichter
{
private:
    std::vector<Licht> LichterListe;
    bool Erreicht();

public:
    Lichter(/* args */);
    ~Lichter();
    void Add(Licht l);
    void Loop();
};
