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
    public partial class fLok : Form
    {
        private readonly Properties.Settings Props;

        public fLok()
        {
            InitializeComponent();
            Text = Properties.Resources.LokFenstertitel ;
#if DEBUG
            Text += " DEBUG";
#else
            Text += Application.CompanyName + ": " + Application.ProductName;
#endif
            Props = Properties.Settings.Default;

        }
    }
}
