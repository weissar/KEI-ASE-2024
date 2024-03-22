using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {

  }

  protected void Button1_Click(object sender, EventArgs e)
  {
    int x = int.Parse(hfCounter.Value);
    x++;

    Button1.Text = "Stisknuto " + x + " krat";

    hfCounter.Value = x.ToString();

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

        gwData.DataSource = tbl;
        gwData.DataBind();
      }

      conn.Close();
    }
  }
}