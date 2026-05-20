using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borys.Bahn.Steuerprogramm
{

  class cCmd : Object, IDisposable
  {
    // public uint SBit2;
    private Button Knopf;
    private string Name;
    //  public cLok(String pName, uint pAdresse, Panel pPanel, EventHandler pClick)
    public struct StartbitUndBefehl
    {
      public uint SB2, B;
    };
    private StartbitUndBefehl _befehl;

    public StartbitUndBefehl Befehl
    {
      get { return _befehl; }
      // set { _befehl = value; }
    }
    private bool disposed;
    public cCmd(String pName, uint pStart2, uint pBefehl, Panel pPanel, EventHandler pCmdAuswahl)
    {
      Knopf = new Button();
      Name = pName;
      _befehl.B = pBefehl & 0x003F;
      _befehl.SB2 = pStart2 & 0x0001;
      Knopf.Parent = pPanel;
      Knopf.Tag = this;
      Knopf.Text = Name;
      Knopf.Click += pCmdAuswahl;
      Knopf.BackColor = Color.White;
    }




    #region IDisposable Member
    // Dispose(bool disposing) executes in two distinct scenarios.
    // If disposing equals true, the method has been called directly
    // or indirectly by a user's code. Managed and unmanaged resources
    // can be disposed.
    // If disposing equals false, the method has been called by the
    // runtime from inside the finalizer and you should not reference
    // other objects. Only unmanaged resources can be disposed.
    private void Dispose(bool disposing)
    {
      // Check to see if Dispose has already been called.
      if (!this.disposed)
      {
        // If disposing equals true, dispose all managed
        // and unmanaged resources.
        if (disposing)
        {
          // Dispose managed resources.
          Knopf.Dispose();
        }

        // Call the appropriate methods to clean up
        // unmanaged resources here.
        // If disposing is false,
        // only the following code is executed.
        /*    CloseHandle(handle);
            handle = IntPtr.Zero;*/

        // Note disposing has been done.
        disposed = true;
      }
    }
    public void Dispose()
    {
      Dispose(true);
      // This object will be cleaned up by the Dispose method.
      // Therefore, you should call GC.SupressFinalize to
      // take this object off the finalization queue
      // and prevent finalization code for this object
      // from executing a second time.
      GC.SuppressFinalize(this);
    }
    ~cCmd()
    {
      // Do not re-create Dispose clean-up code here.
      // Calling Dispose(false) is optimal in terms of
      // readability and maintainability.
      Dispose();
    }
    #endregion

  }
}
