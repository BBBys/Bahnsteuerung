namespace Borys.Bahn.CANguru.Com
{
  internal static class CANKonstanten
  {
    /// <summary>
    /// Platzhalter für Daten
    /// </summary>
    public const byte DATEN1 = 0, DATEN2 = 0;
    public const byte cSTOP = 0x00, cGO = 0x01, cHALT = 0x02;
    /// <summary>
    /// Gleisprotokolle
    /// </summary>
    private const byte tMM2 = 0x00, tDCC = 0xc0, tMFX = 0x40;
    /// <summary>
    /// Fahrtrichtung
    /// </summary>
    private const byte lrBleibt = 0, lrVorwärts = 1, lrRückwärts = 2, lrUmschalten = 3;
    /// <summary>
    /// Positionen im 13-Byte-Kommando-Feld
    /// </summary>
    public static uint cbPRM = 1,///Position: Rückmeldung
    cbPLen = 4, cbSubcom = 9, cbSpeedH = 9, cbSpeedL = 10;
    /// <summary>
    /// Befehle
    /// </summary>
    public const byte bSystem = 0, bDiscovery = 2, bMFXbind = 4, bGeschwindigkeit = 8, bRichtung = 0x0a,
          bFunktion = 0x0c, bAutomatisierung = 0x30, bBridgeInit = 0x88;
    private const int bLänge5 = 5;
    private const int bLänge6 = 6;
    public static readonly byte[] STOP = { 0, bSystem, 47, 11, bLänge5, 0, 0, 0, 0, cSTOP, 0, 0, 0 };
    public static readonly byte[] GO = { 0, bSystem, 0x47, 0x11, bLänge5, 0, 0, 0, 0, cGO, 0, 0, 0 };
    //private byte[]              HALT = { 0, bSystem, 47, 11,         5, 0, 0, 0, 0, cHALT, 0, 0, 0 };
    public static readonly byte[] HALT = { 0, bSystem, 47, 11, bLänge5, 0, 0, 0, 0, cHALT, 0, 0, 0 };
    public static readonly byte[] VOR = { 0, bRichtung, 0x4b, 0x58, bLänge5, 0, 0, tMM2, 0x48, lrVorwärts, 0, 0, 0 };
    public static readonly byte[] ZURÜCK = { 0, bRichtung, 0x4b, 0x58, bLänge5, 0, 0, tMM2, 0x48, lrRückwärts, 0, 0, 0 };
    public static readonly byte[] WECHSEL = { 0, bRichtung, 0x4b, 0x58, bLänge5, 0, 0, tMM2, 0x48, lrUmschalten, 0, 0, 0 };
    //private byte[]                V30 = { 0, bGeschwindigkeit, 0x4b, 0x58, 6,       0, 0, tMM2, 0x48,      0,    153, 0, 0 };
    public static readonly byte[] SPEED = { 0, bGeschwindigkeit, 0x4b, 0x58, bLänge6, 0, 0, tMM2, 0x48, DATEN1, DATEN2, 0, 0 };
    //    private byte[] LichtAus = { 0, bFunktion, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 0, 0, 0, 0 };
    //  private byte[] LichtEin = { 0, bFunktion, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 0, 1, 0, 0 };
    //private byte[] BlinkAus = { 0, bFunktion, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 1, 0, 0, 0 };
    //private byte[] BlinkEin = { 0, bFunktion, 0x4b, 0x58, 6, 0, 0, tMM2, 0x48, 1, 1, 0, 0 };
    public static readonly byte[] LOKFUNKTION = { 0, bFunktion, 0x4b, 0x58, bLänge6, 0, 0, tMM2, 0x48, DATEN1, DATEN2, 0, 0 };
  }
}
