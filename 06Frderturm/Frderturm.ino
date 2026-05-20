const int SENSOR = A7;
const int GELB = 7, TURM = 5, WARN = 3, KORB = 2, GRUEN = 9, ROT = 12,MOTOR=13;
const int WARNAN = 3000,TAGLDR=650;
const int WARNAUS = 777,NACHTLDR=500;
const unsigned long ZOBEN = 30, ZABFAHRT = 5, ZFAHRT = 60, ZANKUNFT = 5;
bool tag, dunkel;
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
      for (d = 50; d <500; d = d + 20)
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
BLicht *warn;
Licht *turm, *korb, *gelb, *rot, *gruen,*motor;
enum Ablauf {abStart, abOben, abAbfahrt, abFahrt, abAnkunft} ablauf;
unsigned long abWeiter;
void setup() {
  // put your setup code here, to run once:
  //Serial.begin(9600);
  korb = new Licht(KORB);
  gruen = new Licht(GRUEN);
  rot = new Licht(ROT);
  warn = new BLicht(WARN, WARNAN, WARNAUS);
  turm = new Licht(TURM);
  gelb = new Licht(GELB);
  motor = new Licht(MOTOR);
  abWeiter = 0;
}

void loop() {
  int sensorValue;
  warn->check();
  sensorValue = analogRead(SENSOR);
  tag = (sensorValue > TAGLDR);
  dunkel = (sensorValue < NACHTLDR);
  warn->blinken(!tag);
  turm->setzen(dunkel);
  gelb->setzen(!tag);

  switch (ablauf)
  {
    case abStart:
      korb->ein();
      gruen->ein();
      rot->aus();
      motor->aus();
      ablauf = abOben;
      abWeiter = Weiter(ZOBEN);
      break;
    case abOben:
      if (millis() < abWeiter)  break;
      korb->ein();
      gruen->aus();
      rot->ein();
      ablauf = abAbfahrt;
      abWeiter = Weiter(ZABFAHRT);
      break;

    case abAbfahrt:
      if (millis() < abWeiter)  break;
      motor->ein();
      korb->weg();
      /*aus(); delay(100); korb->ein(); delay(100);
        korb->aus(); delay(90); korb->ein(); delay(100);
        korb->aus(); delay(80); korb->ein(); delay(100);
        korb->aus(); delay(70); korb->ein(); delay(100);
        korb->aus(); delay(110); korb->ein(); delay(50);
        korb->aus(); delay(100); korb->ein(); delay(50);
        korb->aus(); delay(90); korb->ein(); delay(50);
        korb->aus(); delay(80); korb->ein(); delay(50);
        korb->aus(); delay(90); korb->ein(); delay(30);
        korb->aus(); delay(80); korb->ein(); delay(30);
        korb->aus(); delay(70); korb->ein(); delay(30);
        korb->aus(); delay(90); korb->ein(); delay(30);
        korb->aus();*/
      gruen->aus();
      rot->ein();
      ablauf = abFahrt;
      abWeiter = Weiter(ZFAHRT);
      break;

    case abFahrt:
      if (millis() < abWeiter)  break;
      korb->hin();
      /*ein(); delay(90); korb->aus(); delay(30);
      korb->ein(); delay(70); korb->aus(); delay(30);
      korb->ein(); delay(80); korb->aus(); delay(30);
      korb->ein(); delay(90); korb->aus(); delay(30);
      korb->ein(); delay(80); korb->aus(); delay(50);
      korb->ein(); delay(90); korb->aus(); delay(50);
      korb->ein(); delay(100); korb->aus(); delay(50);
      korb->ein(); delay(110); korb->aus(); delay(50);
      korb->ein(); delay(70); korb->aus(); delay(100);
      korb->ein(); delay(80); korb->aus(); delay(100);
      korb->ein(); delay(90); korb->aus(); delay(100);
      korb->ein(); delay(100); korb->aus(); delay(100);
      korb->ein();*/
      motor->aus();
      gruen->aus();
      rot->ein();
      ablauf = abAnkunft;
      abWeiter = Weiter(ZANKUNFT);
      break;

    case abAnkunft:
      if (millis() < abWeiter)  break;
      gruen->ein();
      rot->aus();
      ablauf = abOben;
      abWeiter = Weiter(ZOBEN);
      if(dunkel)abWeiter= Weiter(ZOBEN*3);
      break;

    default:
      abWeiter = 0;
      ablauf = abOben;

  }

}
