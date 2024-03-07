using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;
using System.Security.Authentication;

namespace cv4_udp_recv_send
{
  internal class RecvSendProgram
  {
    static void Main(string[] args)
    {
      Console.WriteLine("UDP recv-sender", Color.LightGreen);

      UdpClient u = new UdpClient(1234);        // predbezne jako vysilac UDP
      u.BeginReceive(new AsyncCallback(UDP_Recv), u);

      IPEndPoint ipeSend = new IPEndPoint(new IPAddress(new byte[] { 192, 168, 5, 107 }), 1234);

      while (true)
      {
        string s = Console.ReadLine();

        if (String.IsNullOrEmpty(s))  // (s == null) || (s.Length == 0))
          break;

        if (s.StartsWith("P"))
        {
          byte b = 0;
          if (byte.TryParse(s.Substring(1), out b))
          {
            ipeSend = new IPEndPoint(new IPAddress(new byte[] { 192, 168, 5, b }), 1234);

            Console.WriteLine($"New target: {ipeSend}", Color.LightSalmon);
            continue;
          }
        }

        Console.WriteLine($"Send: {s}", Color.White);

        byte[] data = Encoding.ASCII.GetBytes(s);
        u.Send(data, data.Length, ipeSend);
      }

      Console.WriteLine("UDP recv-sender FINISH", Color.LightGreen);
    }

    private static void UDP_Recv(IAsyncResult ar)
    {
      UdpClient uu = ar.AsyncState as UdpClient;
      if (uu == null)
        return;

      IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 0);
      byte[] data = uu.EndReceive(ar, ref ipe);

      Console.WriteLine($"Prislo z {ipe}: {Encoding.ASCII.GetString(data)}", Color.Yellow);

      uu.BeginReceive(UDP_Recv, uu);
    }
  }
}
