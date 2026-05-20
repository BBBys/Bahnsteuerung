/**
 * @file Bahnhof.h
 * @author BBB
 * @brief Bahnhof-Beleuchtungssteuerung
 * @version 0.2
 * @date 7 5 Nov 2021
 * 
 * @copyright Copyright (c) 2021
 * 
 */
#ifndef _bahnhof_h
#define _bahnhof_h

#include <Arduino.h>
#include <licht.h>
enum Pixelnummern
{
    pxHalle2,
    pxHalle1,
    pxSchalterhalle,
    pxGaststaette,
    pxWohnzimmer,
    pxKueche,
    nPixel
};
enum LichtAnZeiten
{
    lazKueche,
    lazWerkstatt,
    lazVerkauf,
    lazWohnzimmer,
    lazWirtschaft
};
bool LichtSollAn(uint8_t Stunde,LichtAnZeiten Art);

#endif // _bahnhof_h
