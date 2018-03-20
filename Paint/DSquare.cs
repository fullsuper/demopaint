using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class DSquare: DrawingShape
    {
        public override void Draw(Graphics myGp, Pen myPen)
        {
            if (Math.Abs(p1.X - p2.X) > Math.Abs(p1.Y - p2.Y))
                p2.X = p1.X + p2.Y - p1.Y;
            else
                p2.Y = p1.Y + p2.X - p1.X;

            if (p1.Y>p2.Y)
               myGp.DrawPolygon(myPen, new Point[] { p1, new Point(p1.X, p2.Y), p2, new Point(p2.X, p1.Y) });
            else
                myGp.DrawPolygon(myPen, new Point[] { p2, new Point(p1.X, p2.Y), p1, new Point(p2.X, p1.Y) });

        }

        public override void Fill(Graphics myGp, Brush br)
        {
            throw new NotImplementedException();
        }
    }
}
