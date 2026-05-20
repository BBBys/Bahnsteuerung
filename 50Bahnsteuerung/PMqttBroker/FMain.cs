using MQTTnet;
using MQTTnet.Server;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PMqttBroker
{
  public partial class FMain : Form
  {

    public FMain()
    {
      InitializeComponent();
    }

    private void bEnde_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void bStart_Click(object sender, EventArgs e)
    {
     
    }
  }
}
