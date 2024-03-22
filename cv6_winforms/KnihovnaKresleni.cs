using cv6_library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv6_winforms
{
  public class KnihovnaKresleni : Control
  {
    public KnihovnaKresleni()
    {
      DoubleBuffered = true;
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      Invalidate();
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
      Kresleni.Vykresli(pe.Graphics, this.ClientRectangle);
    }
  }
}
