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
  public partial class Custom : Control
  {
    public Custom()
    {
      InitializeComponent();

      DoubleBuffered = true;
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      // base.OnSizeChanged(e);
      Invalidate();
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
      // base.OnPaint(pe);
      Graphics gr = pe.Graphics;
      Rectangle rect = this.ClientRectangle;

      gr.FillRectangle(Brushes.Aqua, rect);
      gr.FillEllipse(Brushes.Gray, rect);

      gr.DrawLine(Pens.Green, 0, 0, rect.Width - 1, rect.Height - 1);
      gr.DrawLine(Pens.Green, rect.Width - 1, 0, 0, rect.Height - 1);
    }
  }
}
