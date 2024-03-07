using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace cv4_udp_sender
{
  internal class SenderProgram
  {
    static void Main(string[] args)
    {
      Console.WriteLine("UDP sender");

      UdpClient u = new UdpClient();        // predbezne jako vysilac UDP
      u.Connect(new IPAddress(new byte[] { 192,168,5,107 }), 1234);

      while(true)
      {
        string s = Console.ReadLine();

        if (String.IsNullOrEmpty(s))  // (s == null) || (s.Length == 0))
          break;

        Console.WriteLine("Send: {0}", s);  //  ($"Send: {s}");

        byte[] data = Encoding.ASCII.GetBytes(s);
        u.Send(data, data.Length);
      }

      Console.WriteLine("UDP sender FINISH");
    }
  }
}
