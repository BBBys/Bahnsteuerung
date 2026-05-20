/**
 * @file BhfLicht.cpp
 * @author BBB
 * @brief Hilfs-Lichtfunktionen für Bahnhofsbeleuchtung
 * @version 0.2
 * @date 7 5 Nov 2021
 * 
 * @copyright Copyright (c) 2021
 * 
 */
#include "Bahnhof.h"
/**
 * @brief soll Licht an sein zu dieser Stunde?
 * 
 * @param Stunde die Stunde 0...24
 * @param Art des Objekts
 * @return true Licht an, wenn Stunde 6... 9 oder 18...22
 * @return false Licht aus sonst
 */
bool LichtSollAn(uint8_t Stunde,LichtAnZeiten Art)
{switch (Art)
{
case lazKueche:
    return (Stunde >= 5 && Stunde <= 7) || (Stunde >= 17 && Stunde <= 20);
    break;
case lazVerkauf:
    return (Stunde == 8) || (Stunde >= 17 && Stunde <= 20);
    break;
case lazWerkstatt:
    return (Stunde >= 6 && Stunde <= 8) || (Stunde >= 18 && Stunde <= 19);
    break;
case lazWohnzimmer:
    return (Stunde >= 19 && Stunde <= 22);
    break;
case lazWirtschaft:
    return (Stunde <= 2) || (Stunde >= 19 );
    break;

default: return (Stunde > 5 && Stunde < 9) || (Stunde > 17 && Stunde < 23);
    break;
}
   
}
