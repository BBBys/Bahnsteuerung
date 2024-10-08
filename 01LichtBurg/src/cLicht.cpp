#include <Arduino.h>
#include "Licht.h"
class Licht
{
private:
protected:
    int Pin;
    bool istAn;

public:
    Licht(int pPin)
    {
        Pin = pPin;
        pinMode(Pin, OUTPUT);
        digitalWrite(Pin, LOW);
        istAn = false;
    }
    void aus()
    {
        digitalWrite(Pin, LOW);
        istAn = false;
    }
    void ein()
    {
        digitalWrite(Pin, HIGH);
        istAn = true;
    }
    void setzen(bool p)
    {
        if (p)
            ein();
        else
            aus();
    }
    void weg()
    {
        int d;
        for (d = 500; d > 50; d = d - 20)
        {
            aus();
            delay(75);
            ein();
            delay(d);
        }
        aus();
    }
    void hin()
    {
        int d;
        for (d = 50; d < 500; d = d + 20)
        {
            ein();
            delay(d);
            aus();
            delay(75);
        }
        ein();
    }
};

class BLicht : Licht
{
private:
    enum Status
    {
        stAus,
        stBlink,
        stEin
    } Stat;

    unsigned long wechsel, Tan, Taus;

public:
    void set(int pTan, int pTaus)
    {
        set(pTan, pTaus, 0);
    }
    void set(int pTan, int pTaus, int pW)
    {
        Tan = pTan;
        Taus = pTaus;
        wechsel = millis() + pW;
        istAn = false;
        digitalWrite(Pin, istAn);
    }
    BLicht(int pPin, int pTan, int pTaus) : Licht(pPin)
    {
        Tan = pTan;
        Taus = pTaus;
        wechsel = 0;
        Stat = stAus;
    }
    void blinken(bool pAn)
    {
        if (pAn)
            Stat = stBlink;
        else
        {
            Stat = stAus;
            digitalWrite(Pin, LOW);
        }
    }
    void check()
    {
        if (Stat = stBlink)
        {
            unsigned long jetzt;
            jetzt = millis();
            if (jetzt > wechsel)
            {
                istAn = !istAn;
                digitalWrite(Pin, istAn);
                wechsel = istAn ? jetzt + Tan : jetzt + Taus;
            }
        }
    }
};
