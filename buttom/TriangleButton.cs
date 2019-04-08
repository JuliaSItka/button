using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace buttom
{
    class TriangleButton:Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath g = new GraphicsPath();
            PointF A = new PointF(175, 50);
            PointF B = new PointF(50, 250);
            PointF C = new PointF(300, 250);
            PointF[] points = { A, C, B };
            g.AddPolygon(points);
           // g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pevent);
        }
    }
}
