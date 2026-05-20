using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borys.Bahn.Steuerprogramm
{

  public partial class fBMeldung : Form
  {
 //   private readonly Properties.Settings Props;
    // This delegate enables asynchronous calls for setting
    // the text property on a TextBox control.
    delegate void dText(string text);

    public fBMeldung()
    {
      InitializeComponent();
      //Props = Properties.Settings.Default;
      tbMeldungen.Lines = new string[40];
    }



    /// <summary>
    /// eine neue Zeile im Fenster unten anzeigen
    /// </summary>
    /// <param name="zeile">neue Zeile</param>
    internal void Add(string zeile)
    {
      string[] tbl;
      // InvokeRequired required compares the thread ID of the
      // calling thread to the thread ID of the creating thread.
      // If these threads are different, it returns true.
      if (tbMeldungen.InvokeRequired)
      {
        dText AddCallback = new dText(Add);
        Invoke(AddCallback, new object[] { zeile });
      }
      else
      {
        int i, nl;
        tbl = tbMeldungen.Lines;
        nl = tbl.Count();
        for (i = 0; i < nl - 1; i++)
          tbl[i] = tbl[i + 1];
        tbl[nl - 1] = zeile.Trim();
        tbMeldungen.Lines = tbl;
      }
    }
  }
}