<%@ WebHandler Language="C#" Class="obrazek" %>

using System;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using cv6_library;

public class obrazek : IHttpHandler
{

  public void ProcessRequest(HttpContext context)
  {
    context.Response.ContentType = "image/png";

    using (Bitmap bmp = new Bitmap(256, 128))
    {
      using (Graphics gr = Graphics.FromImage(bmp))
      {
        Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

        /*
      gr.FillRectangle(Brushes.Red, rect);
      gr.FillEllipse(Brushes.Blue, rect);
        */

        Kresleni.Vykresli(gr, rect);
      }

      bmp.Save(context.Response.OutputStream, ImageFormat.Png);
    }
  }

  public bool IsReusable { get { return false; } }
}
