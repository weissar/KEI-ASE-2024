using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv6_winforms
{
  public class MojeKresleni : Control
  {
    public MojeKresleni()
    {
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

      gr.FillRectangle(Brushes.Orange, rect);
      gr.FillEllipse(Brushes.Green, rect);

      gr.DrawLine(Pens.Yellow, 0, 0, rect.Width - 1, rect.Height - 1);
      gr.DrawLine(Pens.Yellow, rect.Width - 1, 0, 0, rect.Height - 1);

      gr.DrawString(DateTime.Now.ToString("HH:mm:ss.fff"), Font, Brushes.Black, 0, 0);
    }
  }
}
