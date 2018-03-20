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
        public DEllipse()
        {
        }

        public override void Draw(Graphics myGp, Pen myPen)
        {
            controlPanel = new Rectangle
           (
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p2.Y - p1.Y)
            );
            CreatControlPoint();
            GraphicsPath grp = new GraphicsPath();
            grp.AddEllipse(controlPanel);
            region = new Region(grp);

            myGp.DrawEllipse(myPen, controlPanel);
        }

        public override void Fill(Graphics myGp, Brush br)
        {
          controlPanel = new Rectangle
          (
               Math.Min(p1.X, p2.X),
               Math.Min(p1.Y, p2.Y),
               Math.Abs(p1.X - p2.X),
               Math.Abs(p2.Y - p1.Y)
           );
            CreatControlPoint();

            GraphicsPath grp = new GraphicsPath();
            grp.AddEllipse(controlPanel);
            region = new Region(grp);

            myGp.FillEllipse(br, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
        }
        private void CreatControlPoint()
        {
            controlPoint.Add(new Point(controlPanel.Location.X, controlPanel.Location.Y));
            controlPoint.Add(new Point(controlPanel.X + controlPanel.Width / 2, controlPanel.Y));
            controlPoint.Add(new Point(controlPanel.X + controlPanel.Width, controlPanel.Y));
            controlPoint.Add(new Point(controlPanel.X + controlPanel.Width, controlPanel.Y + controlPanel.Height / 2));
            controlPoint.Add(new Point(controlPanel.X + controlPanel.Width, controlPanel.Y + controlPanel.Height));
            controlPoint.Add(new Point(controlPanel.X + controlPanel.Width / 2, controlPanel.Y + controlPanel.Height));
            controlPoint.Add(new Point(controlPanel.X, controlPanel.Y + controlPanel.Height));
            controlPoint.Add(new Point(controlPanel.X, controlPanel.Y + controlPanel.Height / 2));
        }
    }
}
