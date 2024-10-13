# Einrichtung von MQTT

## vorweg

```c#

#include <EspMQTTClient.h>
extern EspMQTTClient client;
```

## setup

```c#
/// MQTT
#ifdef NDEBUG
  client.enableDebuggingMessages(false);
#else
  client.enableDebuggingMessages(true);
#endif
  client.enableHTTPWebUpdater("/");
  client.enableLastWillMessage("PGM/lastwill", "Abbruch PGM"); /// LWT-Meldung
  log_d("MQTT---Init OK");
```

## Loop

```c#
  client.loop();  //für MQTT
  delay(500);

```
