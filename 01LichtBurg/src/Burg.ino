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
    aus()
    {
      digitalWrite(Pin, LOW);
      istAn = false;
    }
    ein()
    {
      digitalWrite(Pin, HIGH);
      istAn = true;
    }
    setzen(bool p)
    {
      if (p)ein();
      else aus();
    }
    weg()
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
    hin()
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
    enum Status {stAus, stBlink, stEin} Stat;

    unsigned long wechsel, Tan, Taus;
  public:
    set(int pTan, int pTaus)
    {
      set(pTan, pTaus, 0);
    }
    set(int pTan, int pTaus, int pW)
    {
      Tan = pTan;
      Taus = pTaus;
      wechsel = millis() + pW;
      istAn = false;
      digitalWrite(Pin, istAn);
    }
    BLicht(int pPin, int pTan, int pTaus): Licht(pPin)
    {
      Tan = pTan;
      Taus = pTaus;
      wechsel = 0;
      Stat = stAus;
    }
    blinken(bool pAn)
    {
      if (pAn)Stat = stBlink;
      else
      {
        Stat = stAus;
        digitalWrite(Pin, LOW);
      }
    }
    check()
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
unsigned long Weiter(unsigned long zeit)
{
  return millis() + 1000L * zeit;
}
const int SENSOR = A4;
const int TURM1 = 13;
const int TURM2 = 12;
const int INNEN = 3;
const int FRONT = 4;
const int AUGEN1 = 7;
const int AUGEN2 = 8;
const int BODEN = 5;
const int TURMAN = 5000;
const int TURMAUS = 777;
const unsigned long NORMALZEIT = 60 * 1000L;
const unsigned long DUNKELZEIT = 30 * 1000L;
enum  Stat {start, normal, stAus, dunkel1, dunkel2, dunkel3} stat;
unsigned long wechsel = 0;
bool tag = true,dunkel=true;
Licht *innen, *front, *boden;
BLicht *turm1, *turm2, *augen1, *augen2;
// the setup function runs once when you press reset or power the board
void setup() {
  stat = start;
  augen2 = new BLicht(AUGEN2, 10000, 200);
  augen1 = new BLicht(AUGEN1, 11000, 250);
  boden = new Licht(BODEN);
  innen = new Licht(INNEN);
  front = new Licht(FRONT);
  turm1 = new BLicht(TURM1, TURMAN - 33, TURMAUS);
  turm2 = new BLicht(TURM2, TURMAN + 33, TURMAUS);
  randomSeed(analogRead(0));
}

// the loop function runs over and over again forever
void loop() {
  int sensorValue;
  sensorValue = analogRead(SENSOR);
  tag = (sensorValue > 600);
  dunkel = (sensorValue < 700);
  turm1->check();
  turm2->check();
  augen1->check();
  augen2->check();
  if (!dunkel)
  {
    turm1->blinken(false);
    turm2->blinken(false);
  }
  if (tag)
  {
    stat = start;
    augen2->blinken(false);
    augen1->blinken(false);
    boden->aus();
    innen->aus();
    front->aus();
  }
  else
  {
    switch (stat)
    {
      case start:
        turm2->blinken(true);
        turm1->blinken(true);
        augen1->blinken(false);
        delay(2000);
        augen2->blinken(false);
        delay(3000);
        innen->ein();
        delay(500);
        front->ein();
        delay(2000);
        boden->ein();
        stat = normal;
        wechsel = millis() + NORMALZEIT;
        break;
      case normal:
        if (millis() > wechsel)stat = stAus;
        break;
      case stAus:
        innen->aus();
        delay (333);
        front->aus();
        delay (222);
        boden->aus();
        innen->ein();
        delay(222);
        innen->aus();
        front->ein();
        delay(100);
        front->aus();
        augen1->blinken(true);
        delay(222);
        stat = dunkel1;
        wechsel = millis() + DUNKELZEIT;
        break;
      case dunkel1:
        if (millis() > wechsel)
        {
          augen2->blinken(true);
          for (int i = 0; i < random(3, 7); i++)
          {
            boden->ein();
            augen1->check();
            augen2->check();
            delay (random(50, 777));
            boden->aus();
            augen1->check();
            augen2->check();
            delay (700);
            augen1->blinken(true);
            innen->ein();
            augen1->check();
            augen2->check();
            delay (random(50, 666));
            innen->aus();
            augen1->check();
            augen2->check();
            delay (460);
            boden->ein();
            augen1->check();
            augen2->check();
            delay (random(50, 555));
            boden->aus();
            augen1->check();
            augen2->check();
            delay (340);
            augen1->check();
            augen2->check();
            augen1->blinken(false);
            front->ein();
            augen1->check();
            augen2->check();
            delay (random(50, 444));
            front->aus();
            augen1->check();
            augen2->check();
            delay (225);
            boden->ein();
            augen1->check();
            augen2->check();
            delay (random(50, 333));
            boden->aus();
            augen1->check();
            augen2->check();
            delay (150);
            innen->ein();
            augen1->check();
            augen2->check();
            delay (random(50, 222));
            innen->aus();
            augen1->check();
            augen2->check();
            delay (100);
            augen1->check();
            augen2->check();
          }
          wechsel = millis() + DUNKELZEIT;
          stat = dunkel2;
        }/*if millis>wechsel*/
        break;
      case dunkel2:
        turm1->blinken(false);
        turm2->blinken(false);
        if (millis() > wechsel)
        {
          augen2->blinken(true);
          boden->ein();
          augen1->check();
          augen2->check();
          delay (50);
          boden->aus();
          augen1->check();
          augen2->check();
          delay (random(50, 150));
          boden->ein();
          augen1->check();
          augen2->check();
          delay (50);
          boden->aus();
          augen1->check();
          augen2->check();
          delay (random(50, 150));
          boden->ein();
          augen1->check();
          augen2->check();
          delay (50);
          boden->aus();
          augen1->check();
          augen2->check();
          delay (random(50, 150));
          boden->ein();
          augen1->check();
          augen2->check();
          delay (50);
          boden->aus();
          augen1->check();
          augen2->check();
          delay (random(50, 150));
          augen1->blinken(true);
          wechsel = millis() + DUNKELZEIT;
          stat = dunkel3;
        }
        break;
      case dunkel3:
        augen1->check();
        augen2->check();
        if (millis() > wechsel)stat = start;
        break;
    }
  }
}

