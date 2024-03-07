using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace cv4_UDP_recv
{
  internal class RecvProgram
  {
    static void Main(string[] args)
    {
      Console.WriteLine("UDP receiver");

      UdpClient u = new UdpClient(1234);        // predbezne jako prijimac UDP
      u.BeginReceive(new AsyncCallback(UDP_Recv), u);

      while (true)
      {
        ConsoleKeyInfo cki = Console.ReadKey();
        if ((cki.Key == ConsoleKey.Q) || (cki.Key == ConsoleKey.Escape))
          break;
      }

      Console.WriteLine("UDP receiver FINISH");
    }

    private static void UDP_Recv(IAsyncResult ar)
    {
      UdpClient uu = ar.AsyncState as UdpClient;
      if (uu == null)
        return;

      IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 0);
      byte[] data = uu.EndReceive(ar, ref ipe);

      Console.WriteLine("Prislo z {0}: {1}", ipe, Encoding.ASCII.GetString(data));

      uu.BeginReceive(UDP_Recv, uu);
    }
  }
}
