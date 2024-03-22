using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv6_library
{
  public class Kresleni
  {
    public static void Vykresli(Graphics gr, Rectangle rect)
    {
      gr.FillRectangle(Brushes.DarkBlue, rect);
      gr.FillEllipse(Brushes.LightGreen, rect);

      gr.DrawLine(Pens.Yellow, 0, 0, rect.Width - 1, rect.Height - 1);
      gr.DrawLine(Pens.Yellow, rect.Width - 1, 0, 0, rect.Height - 1);

      using (Font fnt = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold))
      {
        gr.DrawString(DateTime.Now.ToString("HH:mm:ss.fff"), fnt, Brushes.White, 0, 0);

        int x = 0;
        using (SqlConnection conn = new SqlConnection(
          "Data Source=147.228.90.71;Initial Catalog=ase;User ID=ase;Password=ase"))
        {
          conn.Open();
          using (SqlCommand cmd = conn.CreateCommand())
          {
            cmd.CommandText = "SELECT COUNT(*) FROM teploty";
            x = (int)cmd.ExecuteScalar();
          }
        }

        gr.DrawString($"Pocet: {x}", fnt, Brushes.Black, 0, 64);
      }
    }
  }
}
