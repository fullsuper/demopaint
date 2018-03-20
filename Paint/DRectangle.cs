using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    class DRectangle :  DrawingShape
    {
        public override void Draw(Graphics myGp, Pen myPen)
        {
            myGp.DrawPolygon(myPen, new Point[] { p1, new Point(p1.X, p2.Y), p2, new Point(p2.X, p1.Y) });
        }

        public override void Fill(Graphics myGp, Brush br)
        {
            myGp.FillPolygon(br, new Point[] { p1, new Point(p1.X, p2.Y), p2, new Point(p2.X, p1.Y) });
        }
    }
}
