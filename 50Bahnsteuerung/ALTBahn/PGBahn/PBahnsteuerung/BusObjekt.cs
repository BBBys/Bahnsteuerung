using System;

namespace Borys.Bahn.Bahnsteuerung
{
  /// <summary>
  /// Objekt auf dem Buss, das eine eigene Adresse hat
  /// </summary>
  public class cBusObjekt : Object
  {

    private uint adresse;

    /// <summary>
    /// Name des Bus-Objekts
    /// </summary>
    private string name;

    public uint Adresse { get => adresse; set => adresse = value; }
    public string Name { get => name; set => name = value; }
  }
}
