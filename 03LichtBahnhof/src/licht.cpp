/**
 * @file licht.cpp
 * @brief Licht am Bahnhof
 * @version 1.1
 * @date 15 Okt 2024
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024  B. Borys
 */
//  #include <experimental/random>
#include "licht.h"
Lichter lichter();
Lichter::Lichter(/* args */)
{
}

Lichter::~Lichter()
{
}
class Licht
{
private:
    int TAn, TAus, Nr;
    long Zeit;
    bool Ziel,Ist;
    const bool LichtAn = true, LichtAus = false;

public:
void    Loop();
    Licht(int nr);
    Licht(int nr, int an, int aus);
    ~Licht();
   void An();
    void An(int an, int aus);
};

Licht::Licht(int nr) { Licht(nr, 60, 0);
   
}
Licht::An() { An(60); }
Licht::An(int an) { An(an, 0); }
Licht::An(int an, int aus)
{
    TAn = an<<6;
    TAus = aus << 6;
    Zeit = millis() + (randint(0,30)-15)*10;
    Ziel = LichtAn;
}
Licht::Licht(int nr, int an, int aus)
{
    Nr = nr;
    TAn = an << 6;
    TAus = aus << 6;
    Zeit = 0;
    Ziel = Ist = LichtAus;
    }
Licht::Loop()
{}
Licht::~Licht()
{
}
