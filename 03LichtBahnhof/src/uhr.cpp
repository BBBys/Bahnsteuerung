#include "bahnhof.h"
#include "uhr.h"

Uhr uhr;

Uhr::Uhr( int r)
{                                              // by default, we'll generate the high voltage from the 3.3v line internally! (neat!)
    Displ.begin(SSD1306_SWITCHCAPVCC, 0x3c); // initialize with the I2C addr 0x3D (for the 128x64) oder 3C oder 7A oder 78
                                               // init done
    Displ.clearDisplay();
    H = Displ.height();
    W = Displ.width();
    int HH = 22;
    int MM = 59;
    int SEC = 0;
    R = r;
    X0 = W / 2;
    Y0 = H / 2;
}

Uhr::~Uhr()
{
}
/// @brief zeichne Zifferblatt der Uhr mit Stundenmarkierungen
void Uhr::zifferblatt()
{
    Displ.drawCircle(X0, Y0, R, WHITE);
    float wi = 3.1415926535898 / 6.0;
    for (int i = 0; i < 11.99; i++)
    {
        float x, y;
        x = R * sin(i * wi);
        y = R * cos(i * wi);
        Displ.drawLine(0.9 * x + X0, 0.9 * y + Y0, 0.8 * x + X0, 0.8 * y + Y0, WHITE);
    }
};
/// @brief setzt Zeit auf kur vor die angegebene Stunde
/// @param std Stunde, wo gleich anfängt
void Uhr::stellen(u_int8_t std)
{
    struct tm t = {0, 0, 0, 1, 7, 2024, 0, 0, 0};
    /*std--;
    if (std < 0)
        std = 23;*/
    std = (std < 0) ? 23 : std - 1;
    t.tm_hour = std;
    t.tm_min = 58;
    Zeit = mktime(&t);
    verstellt = true;
}
/// @brief lösche Uhr und zeichne neu mit aktueller Uhrzeit
/// @todo Uhrzeit?
void Uhr::loop()
{
    Displ.clearDisplay();
    zifferblatt();
    stdzeiger(HH, MM);
    minzeiger(MM);
    minzeiger(SEC);
    Displ.display();
    SEC++;
    if (SEC > 59)
    {
        SEC = 0;
        MM++;
        if (MM > 59)
        {
            MM = 0;
            HH++;
            if (HH > 23)
                HH = 0;
        }
        }
        verstellt = false;
}

/// @brief Zeichne Stundenzeiger der Bahnhofsuhr
/// @param x0, y0, r Mittelpunkt und Radius der Uhr
/// @param std, mn aktuelle Stunde und Minute
void Uhr::stdzeiger(int std, int mn)
{
    float st = (float)std + (float)mn / 60.0;
    float wi = 3.1415926535898 / 6.0;
    float x, y, f = 0.4;
    x = R * sin(st * wi);
    y = -R * cos(st * wi);
    Displ.drawLine(X0, Y0, f * x + X0, f * y + Y0, WHITE);
}
/// @brief zeichne Minutenzeiger auf Display
/// @param mn aktuelle Minute
void Uhr::minzeiger( int mn)
{
    float wi = 3.1415926535898 / 30.0;
    float x, y, f = 0.7;
    x = R * sin(mn * wi);
    y = -R * cos(mn * wi);
    Displ.drawLine(X0, Y0, f * x + X0, f * y + Y0, WHITE);
}
