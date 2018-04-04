using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class DPolygon : DrawingShape
    {
        private Point centerPoint;
        public int vertices;

        private List<Point> controlPoint;

        public DPolygon(int vertices)
        {
            this.vertices = vertices;
        }

        private Point DegreesToXY(float degrees, float radius, Point origin)
        {
            Point xy = new Point();
            double radians = degrees * Math.PI / 180.0;
            xy.X = (int)(Math.Cos(radians) * radius + origin.X);
            xy.Y = (int)(Math.Sin(radians) * radius + origin.Y);
            return xy;
        }
        private void CreatControlPoint()
        {
            int radius = (int)Math.Sqrt((p1.X - centerPoint.X) * (p1.X - centerPoint.X) + (p1.Y - centerPoint.Y) * (p1.Y - centerPoint.Y));
            float step = 360.0f / vertices;
            float angle = 0;
            for (float i = 0; i < 360; i += step)
            {
                this.controlPoint.Add(DegreesToXY(angle, radius, centerPoint));
                angle += step;
            }
        }

        public override void DrawNoFill(Graphics Gp)
        {
            controlPoint = new List<Point>();
            centerPoint = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
            CreatControlPoint();
            Gp.DrawPolygon(PenDraw, controlPoint.ToArray());
            GraphicsPath g2 = new GraphicsPath();
            g2.AddPolygon(controlPoint.ToArray());
            region = new Region(g2);
        }

        public override void DrawFill(Graphics Gp)
        {
            controlPoint = new List<Point>();
            centerPoint = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
            CreatControlPoint();
            Gp.FillPolygon(PenDraw.Brush, controlPoint.ToArray());
            GraphicsPath g2 = new GraphicsPath();
            g2.AddPolygon(controlPoint.ToArray());
            region = new Region(g2);
        }
    }
}
