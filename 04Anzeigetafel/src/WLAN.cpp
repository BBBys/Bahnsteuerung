#include <ESP8266WiFi.h>
#include "BhfAnz.h"
/**
 * @brief WLAN Verbindung initialisieren
 * 
 * @return boolean true, wenn verbunden
 */
boolean initWiFi()
{
    wl_status_t status = WL_IDLE_STATUS; // the Wifi radio's status
    uint8 i;
    boolean connected = false;
    const char ssid[] = "Zeller14";
    const char *pass = "HiermitKommeIchInsNetz";
    // attempt to connect to Wifi network:
    WiFi.mode(WIFI_STA);
    i = 0;
    while (status != WL_CONNECTED)
    {
#ifndef NDEBUG
        Serial.print("Attempting to connect to WPA SSID: ");
        Serial.println(ssid);
#endif
        WiFi.begin(ssid, pass);
        connected = (WiFi.status() == WL_CONNECTED);
        if (connected)
            break;
        delay(5000);
        connected = (WiFi.status() == WL_CONNECTED);
        if (connected || i++ > 6)
            break;
    }
#ifndef NDEBUG
    Serial.println(connected ? "...verbunden" : "...FEHLER!");
#endif
    return connected;
}
