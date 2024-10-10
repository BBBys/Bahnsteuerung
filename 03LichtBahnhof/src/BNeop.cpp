/**
 * @file MHNeop.cpp
 * @brief Lichterkette für Bahnhof
 * @version 1.1
 * @date 10 Okt 2024 
 *
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024 B. Borys
 */
#include <Adafruit_NeoPixel.h>
#include "bahnhof.h"
int iNUMPIXELS = 0, NEOPIXELPIN = 0;
extern tZustande Zustand,
    Unterzst;
Adafruit_NeoPixel pixels(iNUMPIXELS, NEOPIXELPIN, NEO_GRB + NEO_KHZ800);
// Adafruit_NeoPixel pixels(iNUMPIXELS, NEOPIXELPIN,);
#define DELAYVAL 500 // Time (in milliseconds) to pause between pixels

