using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint
{
    class DEllipse : DrawingShape
    {

        public override void DrawShape(Graphics Gp)
        {
            controlPanel = new Rectangle(
                 Math.Min(p1.X, p2.X),
                 Math.Min(p1.Y, p2.Y),
                 Math.Abs(p1.X - p2.X),
                 Math.Abs(p1.Y - p2.Y)
                 );
            GraphicsPath grp = new GraphicsPath();
            grp.AddEllipse(controlPanel);
            region = new Region(grp);

            base.DrawShape(Gp);
        }
        public override void DrawFill(Graphics Gp)
        {
            Gp.FillEllipse(PenDraw.Brush, controlPanel);
        }

        public override void DrawNoFill(Graphics Gp)
        {
            GraphicsPath grp = new GraphicsPath();
            grp.AddEllipse(controlPanel);
            region = new Region(grp);

            Gp.DrawEllipse(PenDraw, controlPanel);
        }
    }
}
