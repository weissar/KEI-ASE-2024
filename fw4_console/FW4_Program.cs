using System;
using System.Collections.Generic;

namespace fw4_console
{
  internal class FW4_Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ahoj ASE");
      /*
      for (int i = 0; i < 40; i++)
        Console.WriteLine("{0} {0:X}", i);

      Console.Title = 255.ToString("X04");   //  "ASE";
      */

      int[] pole = new int[] { 1, 2, 4, 8 };
      for(int i = 0;i< pole.Length; i++)
        Console.WriteLine("Pole[{0}] = {1}".ToUpper(), i, pole[i]);
      /*
      string[] spole = new string[] { "kei", "ase" };
      for (int i = 0; i < spole.Length; i++)
        Console.WriteLine("SPole[{0}] = {1}".ToUpper(), i, spole[i]);
      */
      List<string> retezce = new List<string>() { "prvni" };
      while(true)
      {
        for (int i = 0; i < retezce.Count; i++)
          Console.WriteLine("SPole[{0}] = {1}".ToUpper(), i, retezce[i]);

        string s = Console.ReadLine();
        if (String.IsNullOrEmpty(s))   // (s == null) || (s.Length == 0))
          break;

        if (retezce.Contains(s))
          retezce.Remove(s);
        else
          retezce.Add(s);
      }

      Console.WriteLine("... Konec");
    }
  }
}
