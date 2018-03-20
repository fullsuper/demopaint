using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class DCircle: DrawingShape
    {
        public override void Draw(Graphics myGp, Pen myPen)
        {
            if (Math.Abs(p1.X - p2.X) > Math.Abs(p1.Y - p2.Y))
                p2.X = p1.X + p2.Y - p1.Y;
            else
                p2.Y = p1.Y + p2.X - p1.X;
            myGp.DrawEllipse(myPen, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
        }

        public override void Fill(Graphics myGp, Brush br)
        {
            if (Math.Abs(p1.X - p2.X) > Math.Abs(p1.Y - p2.Y))
                p2.X = p1.X + p2.Y - p1.Y;
            else
                p2.Y = p1.Y + p2.X - p1.X;
            myGp.FillEllipse(br, this.p2.X, this.p2.Y, this.p2.X - this.p2.X, this.p2.Y - this.p2.Y);
        }
    }
}
