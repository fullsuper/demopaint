using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    abstract class DrawingShape
    {
        protected Region region = new Region();
        public Point p1, p2;
        public Rectangle controlPanel;
        public bool isFill = false;
        public Pen PenDraw = new Pen(Color.Black, 1);
        public virtual bool isSelected(Point p)
        {
            if (region.IsVisible(p))
                return true;
            return false;
        }
        public virtual bool isSelected(Rectangle p)
        {
            if (region.IsVisible(p))
                return true;
            return false;
        }
        public virtual void MoveShape(int dX, int dY)
        {
            p1.X += dX;
            p1.Y += dY;
            p2.X += dX;
            p2.Y += dY;
        }
        public virtual void DrawShape(Graphics Gp, Pen PenDraw, bool isFill)
        {
            this.isFill = isFill;
            this.PenDraw = new Pen(PenDraw.Brush, PenDraw.Width)
            {
                Width = PenDraw.Width,
                DashStyle = PenDraw.DashStyle
            };
            DrawShape(Gp);
        }
        public virtual void DrawShape(Graphics Gp)
        {
            if (this.isFill)
                DrawFill(Gp);
            else
                DrawNoFill(Gp);
        }
        public abstract void DrawNoFill(Graphics Gp);
        public abstract void DrawFill(Graphics Gp);
    }
}
