#pragma once
class Licht
{
private:
protected:
    int Pin;
    bool istAn;
public:
    Licht(int pPin);
    void aus();
    void ein();
    void setzen(bool p);
    void weg();
    void hin();
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
    void set(int pTan, int pTaus);
    void set(int pTan, int pTaus, int pW);
    BLicht(int pPin, int pTan, int pTaus) : Licht(pPin){};
    void blinken(bool pAn);
    void check();
};
