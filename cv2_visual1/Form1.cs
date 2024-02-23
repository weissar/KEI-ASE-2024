using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv2_visual1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    int cnt = 0;

    private void btnFirst_Click(object sender, EventArgs e)
    {
      lblYellow.Text = $"Tlacitko {++cnt}";
    }

    int hcnt = 0;
    private void btnFirst_MouseHover(object sender, EventArgs e)
    {
    }

    private void button1_MouseMove(object sender, MouseEventArgs e)
    {
      lblYellow.Text = $"Button Move {++hcnt}";

    }

    private void rb_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton rb = sender as RadioButton;
      if (rb != null)
      {
        lblYellow.Text += $"\n{rb.Text} - {rb.Checked}";
      }
      else
        lblYellow.Text += $"\n{sender}";
    }
  }
}
