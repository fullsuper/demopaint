using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class DSquare: DRectangle
    {
        public override void DrawShape(Graphics Gp)
        {
            int length = Math.Min(Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));

            if (p1.X > p2.X)
            {
                p2.X = p1.X - length;
            }
            else
                p2.X = p1.X + length;
            if (p1.Y > p2.Y)
            {
                p2.Y = p1.Y - length;
            }
            else
                p2.Y = p1.Y + length;

            controlPanel = 
                new Rectangle(Math.Min(p1.X, p2.X),Math.Min(p1.Y, p2.Y),length,length);
            GraphicsPath grp = new GraphicsPath();
            grp.AddRectangle(controlPanel);
            region = new Region(grp);

            if (this.isFill)
                this.DrawFill(Gp);
            else
                this.DrawNoFill(Gp);
        }
    }
}
