/**
 * @file led.cpp
 * @brief Test LED
 * @version 1.1
 * @date 1 Nov 29 Okt 2024
 * @author Dr. Burkhard Borys, Zeller Ring 15, 34246 Vellmar, Deutschland
 * @copyright Copyright (c) 2024  B. Borys
 */
#include <Arduino.h>
#include "test.h"

int LedHelligkeit(int wert)
{
    static double A = 0.0033, B = 0.1046;
    return (int)(wert * wert * A + wert * B);
}
const int Tafel = PIN_DAC1, Grill = PIN_DAC2;
/**
 * @brief
 *
 */
void ledsetup()
{
    pinMode(Tafel, OUTPUT);
    pinMode(Grill, ANALOG);
}

void ledloop()
{
    static int hell = 20;
    //  // turn the LED on (HIGH is the voltage level)
    // analogWrite(Grill, 0); // turn the LED on (HIGH is the voltage level)
    // delay(500);             // wait for a second
    // digitalWrite(Tafel, 0); // turn the LED on (HIGH is the voltage level)
    switch (random(3))
    {
    case 0:
        //digitalWrite(Tafel, 1);
        hell += 15;
        break;
    case 1:
        //digitalWrite(Tafel, 0);
        hell -= 15;
        break;
    default:
        break;
    }
    hell = min(max(hell, 0), 255);
     analogWrite(Grill, LedHelligkeit(hell));
     delay(333);
     /* Helligkeitsverlauf testen:
         static const n = 7;
         int st[n] = {0, 10, 35, 80, 110, 155, 255};
          for (size_t i = 0; i < n; i++)
          {
              analogWrite(Grill, st[i]);
              delay(1000);
         }
         delay(3000);
         */
}
