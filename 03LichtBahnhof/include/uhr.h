#include <time.h>
#define SSD1306_128_64
//#include <SPI.h>
//#include <Wire.h>
//#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
/*
    // if you just want to use DateTime:
#include <DateTime.h>
    // or if you want to use DateTimeClass and TimeElapsed:
#include <ESPDateTime.h>
    // alias for getTime()
    time_t DateTime.now()
    // get current timestap in seconds
    time_t DateTime.getTime()
    // get utc timestamp in seconds
    time_t DateTime.utcTime()
    // get current timezone
    int DateTime.getTimeZone()
    // get formatted string of time
    String DateTime.toString()
    // format time to string, using strftime
    // http://www.cplusplus.com/reference/ctime/strftime/
    String DateTime.format(const char *fmt);
Quelle https : // blog.mcxiaoke.com/ESPDateTime/
*/
class Uhr
{
private:
    /* data */
    time_t Zeit;
    bool verstellt;
    int H, W, R,HH,MM,SEC;
    float X0, Y0;
    Adafruit_SSD1306 Displ;
   // Adafruit_SSD1306 D;
    void zifferblatt();
    void stdzeiger(int std, int mn);
    void minzeiger(int mn);

public:
    Uhr(int r);
    Uhr() { Uhr(31); };
    ~Uhr();
    void stellen(u_int8_t std);
    void loop();
    };