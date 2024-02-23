using System;
using System.Text;
using System.Threading;

namespace cv2_sbuilder_dtime
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("CV2 StringBuilder a DateTime");

      StringBuilder sb = new StringBuilder();

      for(int i = 0; i < 10; i++)
      {
        sb.Append($"{DateTime.Now:HH:mm:ss.fff} ");
        sb.AppendFormat("Cyklus {0}", i);
        sb.AppendLine();

        Thread.Sleep(150);
      }

      Console.WriteLine(sb.ToString());
    }
  }
}
