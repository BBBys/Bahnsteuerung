#ifndef _LOGGINGMAKROS_H
#define _LOGGINGMAKROS_H

#include <Arduino.h>

#define LOG_DEBUG(fmt, ...) Serial.printf("[DEBUG] " fmt "\n", ##__VA_ARGS__)
#define LOG_INFO(fmt, ...) Serial.printf("[INFO ] " fmt "\n", ##__VA_ARGS__)
#define LOG_WARN(fmt, ...) Serial.printf("[WARN ] " fmt "\n", ##__VA_ARGS__)
#define LOG_ERROR(fmt, ...) Serial.printf("[ERROR] " fmt "\n", ##__VA_ARGS__)

// #define DEBUG_ENABLED 1

#if NDEBUG
#define DEBUG_PRINT(...)
#else
#define DEBUG_PRINT(fmt, ...) Serial.printf(fmt "\n", ##__VA_ARGS__)
#endif

/*
Verwendung:
LOG_DEBUG("Temperatur = %.1f C", temp);
LOG_INFO("WLAN verbunden");
LOG_WARN("RSSI niedrig: %d dBm", WiFi.RSSI());
LOG_ERROR("MQTT-Verbindung fehlgeschlagen");
*/

#endif