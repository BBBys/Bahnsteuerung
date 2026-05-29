using System;
using System.Drawing;
using System.Windows.Forms;

namespace Borys.Bahn.Steuerprogramm
{
  public partial class fBLok : Form
  {
    private bool _Blinklicht = false;
    private bool _Licht = false;
    private int iAdresse;

    public fBLok()
    {
      InitializeComponent();
    }

    public Bitmap Bild { private get { return null; } set { pbBild.Image = value; } }

    public bool Blinklicht
    {
      get { return _Blinklicht; }
      private set { LichtSchalten(value, bBlinklicht); _Blinklicht = value; }
    }
    public bool Licht
    {
      get { return _Licht; }
      private set { LichtSchalten(value, bLicht); _Licht = value; }
    }

    static private void LichtSchalten(bool value, Label pButton)
    {
      if (value)
      { pButton.BackColor = Color.Yellow; }
      else
      { pButton.BackColor = Color.LightGray; }
    }

    public string LokAdresse { get { return iAdresse.ToString(); } set { lAddresse.Text = value; iAdresse = Convert.ToInt32(value); } }
    public string LokName { get { return lLokName.Text; } set { lLokName.Text = value; } }

    private void bBlinklicht_Click(object sender, EventArgs e)
    {
      Blinklicht = !Blinklicht;
    }

    private void bLicht_Click(object sender, EventArgs e)
    {
      Licht = !Licht;
    }
  }
}