using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borys.Bahn.Steuerprogramm
{
  public partial class fBSystem : Form
  {
    private bool _Strom;
    internal SerialPort Com;

    public bool Strom
    {
      get { return _Strom; }
      private set { StromSchalten(value, bStrom); _Strom = value; }
    }

    private void StromSchalten(bool value, Label pButton)
    {
      if (value)
      {
        Com.Write("setpower(1)\n\r");
        pButton.BackColor = Color.Yellow;
      }
      else
      {
        Com.Write("setpower(0)\n\r");
        pButton.BackColor = Color.LightGray;
      }
    }

    public fBSystem()
    {
      InitializeComponent();
    }

    private void bStrom_Click(object sender, EventArgs e)
    {
      Strom = !Strom;
    }

    private void lStopp_Click(object sender, EventArgs e)
    {
      StromSchalten(false,bStrom);
    }
  }
}
