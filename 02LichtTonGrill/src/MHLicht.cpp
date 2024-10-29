/**
 * @file MHLicht.cpp
 * @brief feste Lichter im Musikhaus
 * @version 1.1
 * @date 29 Okt 2024 
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024 B. Borys
 */
#include "musikhaus.h"

cEingangstafel::cEingangstafel(/* args */)
{
    pinMode(EINGANGSTAFEL, OUTPUT);
    digitalWrite(EINGANGSTAFEL, 0);
}

cEingangstafel::~cEingangstafel()
{
}

cGrillfeuer::cGrillfeuer(/* args */)
{
    pinMode(GRILLFEUER, ANALOG);
    analogWrite(GRILLFEUER, 0);
}

cGrillfeuer::~cGrillfeuer()
{
}
