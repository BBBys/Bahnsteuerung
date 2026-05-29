using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Borys.Bahn.CANguru.Com
{
  /// <summary>
  /// alles, was die VErbindung zum CAN-Bus braucht.
  /// Vrbindung wird mit dem Konstruktor aufgebaut
  /// </summary>
  public partial class cCANVerbindung : IDisposable
  {
    private const int PortToCAN = 15731, PortFromCAN = 15730;
    /// <summary>
    /// UDP-Clients zum Senden / Empfangen
    /// </summary>
    private readonly UdpClient ToCAN = null, FromCAN = null;
    //private readonly IPEndPoint RemoteIpEndPoint = null;
    private static AsyncCallback Rcb = null;
    // private bool Receiving = false;
    private string ReceiveString;
    private const byte bSystem = 0, bGeschwindigkeit = 8, bRichtung = 0x0a, bFunktion = 0x0c, bAutomatisierung = 0x30;
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
      // RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, PortFromCAN);
      try
      {
        ToCAN = new UdpClient(PortToCAN);
        FromCAN = new UdpClient(PortFromCAN);
        ToCAN.Connect(CANIP, PortToCAN);
        FromCAN.Connect(CANIP, PortFromCAN);
      }
      catch(Exception e)
      {
        _ = MessageBox.Show(e.Message, "Verbindung herstellen...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        throw;
      }
    }

    internal int Send(uint lokAdresse, byte[ ] befehl)
    {
      befehl[8] = (byte)lokAdresse;
      return Send(befehl);
    }

    internal void Go() => _ = Send(CANKonstanten.GO);


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
      Dispose(false);
    }

    private void Dispose(bool disposing)
    {
      if(disposing)
      {
        ToCAN.Dispose();
        FromCAN.Dispose();
      }
    }

    public byte[ ] Receive()
    {
      IPEndPoint ep = null;
      return FromCAN.Available > 12 ? FromCAN.Receive(ref ep) : null;

    }

    /// <summary>
    /// Senden an Bridge an CAN
    /// </summary>
    /// <param name="vollständigerBefehl"> 13 Byte Befehl+Daten</param>
    /// <returns>1: Erfolg
    /// -1: nicht alles gesendet
    /// -2 Error</returns>

    internal int Send(byte[ ] vollständigerBefehl)
    {
      int ir;
      try
      {
        if(vollständigerBefehl == null)
          throw new ArgumentNullException(nameof(vollständigerBefehl));
        ir = ToCAN.Send(vollständigerBefehl, 13) == 13 ? 1 : -1;
      }
      catch(Exception e)
      {
        _ = MessageBox.Show(e.Message, "Daten senden...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ir = -2;
      }
      return ir;
    }

    private void ReceiveCallback(IAsyncResult ar)
    {
      UdpClient client = ((UDPInfo)ar.AsyncState).client;
      IPEndPoint endpoint = ((UDPInfo)ar.AsyncState).endpoint;
      byte[] receiveBytes = client.Receive(ref endpoint);
      ReceiveString = Encoding.ASCII.GetString(receiveBytes);
      Console.WriteLine($"Received: {ReceiveString}");
      //byte[] receiveBytes = u.EndReceive(ar, ref e);
      //    client.BeginReceive(new AsyncCallback(ReceiveCallback), (UDPInfo) (ar.AsyncState));
      _ = client.BeginReceive(requestCallback: Rcb, state: (UDPInfo)ar.AsyncState);
    }
    /// <summary>
    /// Senden mit Lokadresse und Daten zum Befehl
    /// </summary>
    /// <param name="lokAdresse"></param>
    /// <param name="befehl"></param>
    /// <param name="daten">32 Bit unsigned, 16 werden verwendet</param>
    internal int Send(uint lokAdresse, byte[ ] befehl, uint daten)
    {
      Byte daten1, daten2;
      daten2 = (Byte)(daten & 0xff);
      daten >>= 8;
      daten1 = (Byte)(daten & 0xff);
      befehl[9] = daten1;
      befehl[10] = daten2;
      return Send(lokAdresse, befehl);
    }
    internal void Send(uint lokAdresse, byte[ ] befehl, uint daten1, uint daten2)
    {
      befehl[9] = (Byte)daten1;
      befehl[10] = (Byte)daten2;
      _ = Send(lokAdresse, befehl);
    }

    internal bool Verbunden()
    {
      bool a, b;
      a = FromCAN.Client.Connected;
      b = ToCAN.Client.Connected;
      return a && b;
    }

    //internal void BeginReceive()
    //{
    //  if (!Receiving)
    //  {
    //    UDPInfo udpinfo = new UDPInfo
    //    {
    //      endpoint = RemoteIpEndPoint,
    //      client = FromCAN
    //    };
    //    FromCAN.BeginReceive(requestCallback: Rcb, state: udpinfo);
    //    Receiving = true;
    //  }
    //}
    public override string ToString() => base.ToString();

    /// <summary>
    /// 
    /// </summary>
    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    internal void Stop() => _ = Send(CANKonstanten.STOP);
  }
}