using System;
using System.Windows.Forms;

namespace Borys.Bahn.Steuerprogramm
{
  public partial class fBMain : Form
  {
    //private readonly Properties.Settings Props;
    private fComport ComFenster;
    internal fBMeldung FMeldung;
    private fBLok FLok1, FLok2, FLok3;
    private fBSystem FSystem;
    private readonly int RAND = 20;
    private fKommando FKommando;

    public fBMain()
    {
      InitializeComponent();
      Text = Properties.Resources.Fenstertitel + " V" + Application.ProductVersion + ". ";
#if DEBUG
      Text += "DEBUGVERSION";
#else
            Text += Application.CompanyName + ": " + Application.ProductName;
#endif

      FMeldung = new fBMeldung();
      FMeldung.MdiParent = this;
      FMeldung.Show();

      FKommando = new fKommando();
      FKommando.MdiParent = this;
      FKommando.Show();

      FSystem = new fBSystem();
      FSystem.Show();
      FSystem.MdiParent = this;
      FSystem.Com = FKommando.Port;

      FLok1 = new fBLok();
      FLok1.MdiParent = this;
      FLok1.Show();
      FLok1.Bild = Properties.Resources.Lok1Bild;
      FLok1.LokName = Properties.Resources.Lok1Name;
      FLok1.LokAdresse = Properties.Resources.Lok1Adresse;

      FLok2 = new fBLok();
      FLok2.MdiParent = this;
      FLok2.Show();
      FLok2.LokName = Properties.Resources.Lok2Name;
      FLok2.LokAdresse = Properties.Resources.Lok2Adresse;
      FLok2.Bild = Properties.Resources.Lok2Bild;

      FLok3 = new fBLok();
      FLok3.MdiParent = this;
      FLok3.Show();
      FLok3.LokName = Properties.Resources.Lok3Name;
      FLok3.LokAdresse = Properties.Resources.Lok3Adresse;
      FLok3.Bild = Properties.Resources.Lok3Bild;

    }

    internal void StatusMeldung(string v)
    {
      tslMeldung.Text = v;
    }


    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      Close();
    }



    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      if (ComFenster == null)
      {
        ComFenster = new fComport();
        ComFenster.Kommando = FKommando;
      }
      ComFenster.Show(this);
    }

    private void tsbTest_Click(object sender, EventArgs e)
    {


    }

    private void fBMain_Shown(object sender, EventArgs e)
    {
      fBMain_Resize(sender, e);
    }

    private void fBMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      FKommando.PortClose();

      tslMeldung.Text = "Port geschlossen";
      //Props.Save();
    }


    private void fBMain_Resize(object sender, EventArgs e)
    {
      int w, h, w3, h3;
      Form f = (Form)sender;
      w = f.Width;
      w3 = w / 3;
      h = f.Height;
      h3 = h / 3;
      FLok1.Width = FLok2.Width = FLok3.Width = w3 - RAND;
      FLok1.Height = FLok2.Height = FLok3.Height = h3 - RAND;
      FLok1.Top = FLok2.Top = FLok3.Top = 0;
      FLok1.Left = 0;
      FLok2.Left = w3;
      FLok3.Left = 2 * w3;
      FMeldung.Left = 2 * w3;
      FSystem.Top = FMeldung.Top = FKommando.Top = h3;
      FSystem.Width = FMeldung.Width = FKommando.Width = w3 - RAND;
      FSystem.Height = FMeldung.Height = FKommando.Height = h3 - RAND;
      FSystem.Left = 0;
      FKommando.Left = w3;
      FMeldung.Left = 2 * w3;
    }
  }
}