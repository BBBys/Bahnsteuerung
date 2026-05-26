using Borys.Bahn.Bahnsteuerung.PTouch.Properties;
using System;
using System.Windows.Forms;

namespace Borys.Bahsteuerung.PTouch
{
  public partial class FTMain : Form
  {
    public FTMain()
    {
      InitializeComponent();
      Text = Resources.Fenstertitel + ". " + Application.CompanyName + ": " + Application.ProductName + " V" + Application.ProductVersion;

#if DEBUG
      Text += " DEBUGVERSION";
#else
    // Release version
#endif
      tslZeit.Text = DateTime.Now.ToString();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}