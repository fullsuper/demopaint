using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class DBezier:DrawingShape
    {
        public override void DrawShape(Graphics Gp)
        {

            GraphicsPath grp = new GraphicsPath();
            grp.AddBezier(p1, new Point((p1.X + p2.X) / 4, (p1.Y + p2.Y) / 4 + 50), new Point((p1.X + p2.X) * 3 / 4, (p1.Y + p2.Y) * 3 / 5 - 50), p2);
            region = new Region(grp);
            base.DrawShape(Gp);
        }
        public override void DrawNoFill(Graphics Gp)
        {
            Gp.DrawBezier(PenDraw, p1, new Point((p1.X+p2.X)/4, (p1.Y + p2.Y) / 4 + 100), new Point((p1.X + p2.X) *3 / 4 , (p1.Y + p2.Y) *3/ 5 - 100), p2);
        }

        public override void DrawFill(Graphics Gp)
        {
            DrawNoFill(Gp);
        }
    }
}
