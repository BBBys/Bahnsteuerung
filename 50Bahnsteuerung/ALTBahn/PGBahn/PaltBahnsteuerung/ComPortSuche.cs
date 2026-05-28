using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borys.Bahn.Bahnsteuerung
{
  /// <summary>
  /// Port zum Arduino bestimen
  /// </summary>
  internal class ComPortSuche
  {
    public enum Systeme
    {
      Unbekannt, UNIX, Windows
    };
    public readonly Systeme SystemIst = Systeme.Unbekannt;
    public readonly string Port="";

    /// <summary>
    /// Port zum Arduino bestimen
    /// </summary>
    public ComPortSuche()
    {
      string[] allePorts;
      allePorts = SerialPort.GetPortNames();
      if (allePorts.Length < 1)
        throw new Exception("kein serieller Port vorhanden");
      else // Port vorhanden
      {
        if (allePorts[0].Contains("/dev/"))
          SystemIst = Systeme.UNIX;
        else if (allePorts[0].Contains("COM"))
          SystemIst = Systeme.Windows;
        switch (SystemIst)
        {
          case Systeme.UNIX:
            Port = "/dev/Arduino";
            break;
          case Systeme.Windows:
            if (allePorts.Length < 2)
              Port = allePorts[0];//nur einer ist einfach
            else
              throw new Exception("Auswahl aus mehreren seriellen Ports unmöglich"); // mehrere geht nicht
            break;
          case Systeme.Unbekannt:
          default:
            throw new Exception("kein serieller Port erkennbar");
        }
      }
      return;
    }
  }
}