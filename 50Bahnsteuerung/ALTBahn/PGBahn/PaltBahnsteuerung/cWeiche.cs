using Borys.Bahn.ArduinoVerbindung;
using Solid.Arduino.Firmata;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borys.Bahn.Bahnsteuerung
{
  class cWeiche
  {
    public PictureBox Pb { get => pbWeiche; set => pbWeiche = value; }
    public enum WeichenStellung  { stGerade, stAbbiegen };
    PictureBox pbWeiche = null;
    private cArduino Arduino;
    private readonly int Nummer = 0;
    private readonly WeichenStellung Normal ;
  private readonly Bitmap bmAbbiegen,bmGerade;
    readonly String Name;
    internal readonly int Pin;
    private WeichenStellung Stellung;


    /// <summary>
    /// 
    /// </summary>
    /// <param name="pNummer"></param>
    /// <param name="normal"></param>
    /// <param name="pb"></param>
    public cWeiche(int pNummer, string pName, WeichenStellung pNormal, PictureBox pb, System.Drawing.Bitmap pGerade, System.Drawing.Bitmap pAbbiegen, cArduino pArduino)
    {
      Arduino = pArduino;
      Nummer = pNummer;
      Pin = pNummer;
      Normal = pNormal;
      pbWeiche = pb ?? throw new ArgumentNullException(nameof(pb));
      bmGerade = pGerade;
      bmAbbiegen = pAbbiegen;
      Stellung = pNormal;
      Name = pName;
      Arduino.SetPinModeDigitalOutput(Pin);
    }

 

    
    internal Image Bild()
    {
      if (Stellung == WeichenStellung.stGerade)
        return bmGerade;
      else
        return bmAbbiegen;
    }
    internal bool Relais() => (Stellung == Normal);


    public override string ToString() => "Weiche: " + Name;

    internal bool Umstellen()
    {
      if (Stellung == WeichenStellung.stGerade)
        Stellung = WeichenStellung.stAbbiegen;
      else
        Stellung = WeichenStellung.stGerade;
      pbWeiche.BackgroundImage = Bild();
      return Relais();
    }
  }
}
