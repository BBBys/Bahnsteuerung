using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borys.Bahn.Steuerprogramm
{

  /// <summary>
  /// Objekt auf dem Buss, das eine eigene Adresse hat
  /// </summary>
  class cBusObjekt : Object
  {
    /// <summary>
    /// Adresse auf dem Bus
    /// </summary>
    protected uint _adresse;

    public uint Adresse
    {
      get { return _adresse; }
      //           protected set { _adresse = value; } wird nie verwendet
    }
    /// <summary>
    /// Name des Bus-Objekts
    /// </summary>
    protected string Name;

  }
}
