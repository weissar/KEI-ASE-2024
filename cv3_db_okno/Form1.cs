using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv3_db_okno
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      using (SqlConnection conn = new SqlConnection(
        "Data Source=147.228.90.71;Initial Catalog=ase;User ID=ase;Password=ase"))
      {
        conn.Open();

        using (SqlCommand cmd = conn.CreateCommand())
        {
          cmd.CommandText = "SELECT TOP(20) * FROM teploty ORDER BY cas DESC";

          DataTable tbl = new DataTable();
          using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            da.Fill(tbl);

          grid.DataSource = tbl;
        }

        conn.Close();
      }

    }
  }
}
