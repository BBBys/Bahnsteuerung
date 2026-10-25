using System;
using System.Windows.Forms;

namespace Borys.Bahn.Bahnsteuerung
{
  public partial class fSchalten : Form
  {
    private readonly cAnlagenZeit AnlagenZeit;
    internal Action<Button, int, int> ButtonSetzen = null;
    private readonly int BUTTONSIZE;
    private void Anordnen()
    {
      if(ButtonSetzen != null)
      {
        try
        {
          int l, o, rechts, mitte, unten;
          l = 1;
          o = 1;
          rechts = Width;
          unten = Height;
          mitte = Width / 2;
          //  ButtonSetzen(bConfig, l, o);
          l += BUTTONSIZE + 1;
          //ButtonSetzen(bInit, l, o);
          //ButtonSetzen(bStop, rechts- 1 - BUTTONSIZE, o);
          l = mitte - BUTTONSIZE - 1;
          o += BUTTONSIZE + 1;
          //ButtonSetzen(bFahren, l, o);
          l += BUTTONSIZE + 1;
          //ButtonSetzen(bSchalten, l, o);
          ButtonSetzen(bClose, rechts - 1 - BUTTONSIZE, unten - 1 - BUTTONSIZE);
        }
        catch(Exception e)
        {
          _ = MessageBox.Show(e.Message, "anordnen...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
    /// <summary>
    /// Konstruktor
    /// </summary>
    /// <param name="fMain">Zugriff auf Aurufer</param>
    public fSchalten(fMain fMain)
    {
      InitializeComponent();
      BUTTONSIZE = Properties.Settings.Default.BUTTONSIZE;
       AnlagenZeit = fMain.AnlagenZeit;
    }

    private void bClose_Click(object sender, EventArgs e) => Hide();

    private void bClose_Resize(object sender, EventArgs e) => Anordnen();

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void fSchalten_Shown(object sender, EventArgs e)
    {

      tslZeit.Text = DateTime.Now.ToString();
      tslAZeit.Text = AnlagenZeit.Zeit;
    }
  }
}
