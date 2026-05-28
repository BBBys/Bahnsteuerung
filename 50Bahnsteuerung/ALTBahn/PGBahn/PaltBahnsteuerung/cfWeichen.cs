using Borys.Bahn.ArduinoVerbindung;
using Solid.Arduino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borys.Bahn.Bahnsteuerung
{
  public partial class fWeichen : Form
  {
  //  private static PictureBox[] pictureBoxes =new PictureBox[8];
    private cWeiche[] Weichen = new cWeiche[8];
    private readonly cArduino Arduino;

   public fWeichen(cArduino pArduino)  
    {
      InitializeComponent();
      Arduino = pArduino ?? throw new ArgumentNullException(nameof(pArduino));
      int i = 0;
      Weichen[i++] = new cWeiche(9, "Abstellgleis 12", cWeiche.WeichenStellung.stGerade, pb42, Properties.Resources.GleisplanR4C2g, Properties.Resources.GleisplanR4C2a,Arduino);
      Weichen[i++] = new cWeiche(10, "Abstellgleis 99", cWeiche.WeichenStellung.stGerade, pb11, Properties.Resources.GleisplanR1C1g, Properties.Resources.GleisplanR1C1a, Arduino);
      Weichen[i++] = new cWeiche(11, "Zechengleis", cWeiche.WeichenStellung.stGerade, pb13, Properties.Resources.GleisplanR1C3g, Properties.Resources.GleisplanR1C3a, Arduino);
      Weichen[i++] = new cWeiche(12, "Abzw. Tunnen", cWeiche.WeichenStellung.stGerade, pb21, Properties.Resources.GleisplanR2C1g, Properties.Resources.GleisplanR2C1a, Arduino);
      Weichen[i++] = new cWeiche(5, "Gleis 2 Einfahrt", cWeiche.WeichenStellung.stAbbiegen, pb31, Properties.Resources.GleisplanR3C1g, Properties.Resources.GleisplanR3C1a, Arduino);
      Weichen[i++] = new cWeiche(6, "Gleis 2 Ausfahrt", cWeiche.WeichenStellung.stGerade, pb33, Properties.Resources.GleisplanR3C3g, Properties.Resources.GleisplanR3C3a, Arduino);
      Weichen[i++] = new cWeiche(7, "Abstellgleis 13", cWeiche.WeichenStellung.stAbbiegen, pb41, Properties.Resources.GleisplanR4C1g, Properties.Resources.GleisplanR4C1a, Arduino);
      Weichen[i++] = new cWeiche(8, "Gleis 2 Einfahrt", cWeiche.WeichenStellung.stGerade, pb43, Properties.Resources.GleisplanR4C3g, Properties.Resources.GleisplanR4C3a, Arduino);
    }


    private void button1_Click(object sender, EventArgs e)
    {
    
    }

    private void Anordnen()
    {
      const int rand = 4;
      lInfo.Text=$"{Width}x{Height}";
      int wSumme = pb11.Width + pb13.Width;
      int hSumme = pb11.Height + pb21.Height + pb31.Height + pb41.Height;
      int wMax = gbButtons.Left - 2 * rand;
      int hMax = this.Height - 2 * rand;
      float fBreite = (float) wMax / (float) wSumme;
      float fHöhe = (float) hMax / (float) hSumme;
      float faktor = Math.Min(fBreite, fHöhe);
      int oben = rand;
      Setze(pb11, rand, oben, faktor);
      Setze(pb13, pb11.Left + pb11.Width, oben, faktor);
      oben = pb11.Top + pb11.Height;
      Setze(pb21, rand, oben, faktor);
      oben = pb21.Top + pb21.Height;
      Setze(pb31, rand, oben, faktor);
      Setze(pb33, pb31.Left + pb31.Width, oben, faktor);
      oben = pb31.Top + pb31.Height;
      Setze(pb41, rand, oben, faktor);
      Setze(pb42, pb41.Left + pb41.Width, oben, faktor);
      Setze(pb43, pb42.Left + pb42.Width, oben, faktor);
    }

    private static void Setze(PictureBox pb, int l, int o, float f)
    {
      Skaliere(pb, f);
      pb.Left = l;
      pb.Top = o;
    }

    private static void Skaliere(PictureBox pb, float f)
    {
      pb.Width = (int) (f * pb.Width);
      pb.Height = (int) (f * pb.Height);
    }

    private void fWeichen_Resize(object sender, EventArgs e)
    {
      Anordnen();
    }

    private void fWeichen_Shown(object sender, EventArgs e)
    {
      foreach (cWeiche w in Weichen)
      {
        if (w == null)
          break;
        w.Pb.BackgroundImage = w.Bild();
      }
    }

    private void pb11_Click(object sender, EventArgs e)
    {
      bool x;
      PictureBox pb = (PictureBox) sender;
      foreach (cWeiche weiche in Weichen)
      {
        if (weiche.Pb == pb)
        {
          x = weiche.Umstellen();
          Arduino.SetDigitalPin(weiche.Pin,x);
          break;
        }

      }
    }
  }
}
