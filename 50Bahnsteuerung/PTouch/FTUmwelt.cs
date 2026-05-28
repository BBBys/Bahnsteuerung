using System;
using System.Windows.Forms;

namespace Borys.Bahn.Bahnsteuerung.PTouch
{
  public partial class FTUmwelt : Form
  {
    public FTUmwelt()
    {
      InitializeComponent();
    }

    private void button9_Click(object sender, System.EventArgs e)
    {
      Close();
    }

    private void FTUmwelt_Shown(object sender, System.EventArgs e)
    {
      tslZeit.Text = DateTime.Now.ToString();
    }
  }
}
