using System;

namespace Borys.Bahn.Bahnsteuerung
{
  public class cAnlagenZeit
  {
    DateTime Anlagenzeit = new DateTime();
    private TimeSpan Zeitdifferenz;

    public cAnlagenZeit()
    {
      Anlagenzeit = DateTime.Today.AddHours(9);
      Zeitdifferenz = Anlagenzeit.Subtract(DateTime.Now);
    }

    internal string Zeit
    {
      get => zeit(); //set => zeit = value;
    }
    private string zeit() => (DateTime.Now + Zeitdifferenz).ToShortTimeString();
  }
}
