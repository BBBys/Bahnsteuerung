# Vorlage Setup

```c#
void setup()
{
#ifndef NDEBUG
  Serial.begin(115200);
#endif
  log_d("setup...");
  ...
  log_d("Setup OK");
 }
```
