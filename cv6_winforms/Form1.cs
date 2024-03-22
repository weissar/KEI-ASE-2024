using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv6_winforms
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label1_Paint(object sender, PaintEventArgs e)
    {
      Graphics gr = e.Graphics;
      Rectangle rect = label1.ClientRectangle;

      gr.FillRectangle(Brushes.YellowGreen, rect);

      gr.DrawLine(Pens.Black, 0, 0, rect.Width - 1, rect.Height - 1);
      gr.DrawLine(Pens.Black, rect.Width - 1, 0, 0, rect.Height - 1);
    }
  }
}
