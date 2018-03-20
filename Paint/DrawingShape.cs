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
        protected List<Point> controlPoint = new List<Point>();
        public Point p1, p2;
        public Rectangle controlPanel;

        public virtual bool isSelected(Point p)
        {
            //for (int i = 0; i < controlPoint.Count; i++)
            //{
            //    if (controlPoint[i].X == p.X && controlPoint[i].Y == p.Y)
            //        return false;
            //}
            if (region.IsVisible(p))
                return true;
            return false;
        }
        public virtual void MoveShape(Point a, Point b)
        {
            int dx = b.X - a.X;
            int dy = b.Y - a.Y;
            for (int i = 0; i < controlPoint.Count(); i++)
            {
                controlPoint[i] = new Point(controlPoint[i].X + dx, controlPoint[i].Y + dy);
            }
        }
        public virtual void DrawControlPanel(Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.Red);
            //Pen pen = new Pen(Color.Blue);
            for (int i = 0; i < controlPoint.Count(); i++)
            {
                g.FillRectangle(sb, controlPoint[i].X - 4, controlPoint[i].Y - 4, 8, 8);
            }
        }

        public abstract void Draw(Graphics myGp, Pen myPen);
        public abstract void Fill(Graphics myGp, Brush br);
    }
}
