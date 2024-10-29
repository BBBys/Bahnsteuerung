/**
 * @file Licht.h
 * @brief Licht in der Grillhütte
 * @version 1.1
 * @date 29 Okt 2024
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024 B. Borys
 */
#ifndef LICHT_H
#define LICHT_H
#pragma once
#include <Arduino.h>
class cEingangstafel
{
private:
    static const u_int8_t EINGANGSTAFEL = PIN_DAC1;
public:
    cEingangstafel();
    ~cEingangstafel();
};
class cGrillfeuer
{
private:
    static const u_int8_t GRILLFEUER = PIN_DAC2;
public:
    cGrillfeuer();
    ~cGrillfeuer();
};


#endif
