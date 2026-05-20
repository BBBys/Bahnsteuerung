using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borys.Bahn.Steuerprogramm
{

  /// <summary>
  /// eine Lok
  /// </summary>
  class cLok : cBusObjekt, IDisposable
  {
    /// <summary>
    /// zugeordneter Button
    /// </summary>
    /// <remarks>Das Lok-Object wird im Tag des Buttons gespeichert</remarks>
    private Button Knopf;
    private bool disposed;
    /// <summary>
    /// Konstruktor
    /// </summary>
    /// <param name="pName">Name der Lok</param>
    /// <param name="pAdresse">Adresse der Lock auf dem Bus</param>
    /// <param name="pKnopf">Button zur Anwahl der Lok</param>
    public cLok(String pName, uint pAdresse, Panel pPanel, EventHandler pClick)
    {
      Knopf = new Button();
      Name = pName;
      _adresse = pAdresse;
      Knopf.Parent = pPanel;
      Knopf.Tag = this;
      Knopf.Text = Name;
      Knopf.Click += pClick;
      Knopf.BackColor = Color.White;
    }

    #region IDisposable Member

    public void Dispose()
    {
      if (!this.disposed)
        Knopf.Dispose();
      disposed = true;
      GC.SuppressFinalize(this);
    }
    ~cLok() { Dispose(); }
    #endregion
  }
}
