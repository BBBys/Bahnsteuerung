using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Borys.Bahn.CANguru.Com
{
  public partial class cCANVerbindung : IDisposable
  {
    private const int PortToCAN = 15731, PortFromCAN = 15730;
    private readonly UdpClient ToCAN = null;
    private readonly UdpClient FromCAN = null;
    private readonly IPEndPoint RemoteIpEndPoint = null;
    private static AsyncCallback Rcb = null;
    private bool Receiving = false;
    private Label AusgabeLabel;
    private string ReceiveString;
    private const Byte bSystem = 0, bGeschwindigkeit = 8, bRichtung = 0x0a, bFunktion = 0x0c, bAutomatisierung = 0x30;
    /// <summary>
    /// empfangenen Text weiterverarbeiten
    /// This delegate enables asynchronous calls 
    /// </summary>
    /// <param name="text">der empfangene Text</param>
    private delegate void SetTextCallback(string text);

    private struct UDPInfo
    {
      public UdpClient client;
      public IPEndPoint endpoint;
    }

    private readonly IPAddress CANIP;
    public cCANVerbindung(string ip)
    {
      CANIP = IPAddress.Parse(ip);
      Rcb = new AsyncCallback(ReceiveCallback);
      RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, PortFromCAN);
      try
      {
        ToCAN = new UdpClient(PortToCAN);
        FromCAN = new UdpClient(PortFromCAN);
        ToCAN.Connect(CANIP, PortToCAN);
        FromCAN.Connect(CANIP, PortFromCAN);
      }
      catch(Exception e)
      {
        throw;
      }
    }

    /// <summary>
    /// Text aus anderm Thread setzen
    /// </summary>
    /// <remarks>
    /// InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.
    /// If these threads are different, it returns true.
    /// </remarks>
    ~cCANVerbindung()
    {
      ToCAN.Close();
      FromCAN.Close();
      Dispose(disposing: false);
    }

    private void Dispose(bool disposing)
    {
      if(disposing)
      {
        ToCAN.Dispose();
        FromCAN.Dispose();
      }
    }

    public Byte[ ] Receive()
    {
      IPEndPoint ep = null;
      if(FromCAN.Available > 12)
      {
        return FromCAN.Receive(ref ep);
      }
      else
      {
        return null;
      }
    }

    internal int Send(byte[ ] data) => ToCAN.Send(data, 13);

    private void ReceiveCallback(IAsyncResult ar)
    {
      UdpClient client = ((UDPInfo)ar.AsyncState).client;
      IPEndPoint endpoint = ((UDPInfo)ar.AsyncState).endpoint;
      byte[] receiveBytes = client.Receive(ref endpoint);
      int nb = receiveBytes.Length;
      ReceiveString = Encoding.ASCII.GetString(receiveBytes);
      Console.WriteLine($"Received: {ReceiveString}");
      //byte[] receiveBytes = u.EndReceive(ar, ref e);
      //    client.BeginReceive(new AsyncCallback(ReceiveCallback), (UDPInfo) (ar.AsyncState));
      _ = client.BeginReceive(requestCallback: Rcb, state: (UDPInfo)ar.AsyncState);
    }

    internal void BeginReceive()
    {
      if(!Receiving)
      {
        UDPInfo udpinfo = new UDPInfo
        {
          endpoint = RemoteIpEndPoint,
          client = FromCAN
        };
        _ = FromCAN.BeginReceive(requestCallback: Rcb, state: udpinfo);
        Receiving = true;
      }
    }
    public override string ToString() => base.ToString();

    /// <summary>
    /// 
    /// </summary>
    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

  }
}