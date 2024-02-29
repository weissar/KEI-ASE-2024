using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv3_db_konzole
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Program DB Console");

      using (SqlConnection conn = new SqlConnection(
        "Data Source=147.228.90.71;Initial Catalog=ase;User ID=ase;Password=ase"))
      {
        conn.Open();

        using (SqlCommand cmd = conn.CreateCommand())
        {
          cmd.CommandText = "SELECT COUNT(*) FROM teploty";
          // cmd.CommandText = "SELECT 0.5";

          object o = cmd.ExecuteScalar();
          if ((o != null) && (o is int))
          {
            int pocet = (int)o;
            Console.WriteLine("Pocet zaznamu = {0}", pocet);
          }
          else
          {
            Console.WriteLine("Neni INT, vypada jako {0}", o.GetType());
          }

          cmd.CommandText = "SELECT TOP(20) * FROM teploty ORDER BY cas DESC";

          /*
          DataTable tbl = new DataTable();
          using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            da.Fill(tbl);

          foreach(DataColumn col in tbl.Columns)
            Console.Write("{0} ({1})\t", col.ColumnName, col.DataType);

          Console.WriteLine("\n****************************************");

          foreach(DataRow row in tbl.Rows)
          {
            //foreach (object x in row.ItemArray)
            //  Console.Write($"{x}\t");

            //Console.WriteLine();
            Console.WriteLine(String.Join("\t", row.ItemArray));
          }
          */

          using (SqlDataReader rdr = cmd.ExecuteReader())
          {
            if (rdr.HasRows)
            {
              for (int i = 0; i < rdr.FieldCount; i++)
                Console.Write($"{rdr.GetName(i)} ({rdr.GetFieldType(i)})\t");
              Console.WriteLine("\n****************************************");

              while (rdr.Read())
              {
                for (int i = 0; i < rdr.FieldCount; i++)
                  Console.Write($"{rdr.GetValue(i)}\t");

                Console.WriteLine();
              }
            }
          }
        }

        conn.Close();
      }
    }
  }
}
