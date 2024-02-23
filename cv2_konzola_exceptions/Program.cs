using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv2_konzola_exceptions
{
  public class MojeException : Exception
  {
        public MojeException(string popis) : base(popis)
        {
            
        }
    }

  internal class Program
  {
    static /*public*/ void DelejChybu()
    {
      throw new MojeException("Jeste to neni");
    }

    static void Main(string[] args)
    {
      Console.WriteLine("CV2 vyjimky");

      try
      {
        DelejChybu();
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Vyjimka: {ex.Message}, typu {ex.GetType().FullName}");
      }
      // toto urcite NE ... catch { }
    }
  }
}
