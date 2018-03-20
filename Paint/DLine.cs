using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    class DLine :DrawingShape
    {
        public override void Draw(Graphics myGp, Pen myPen)
        {
            myGp.DrawLine(myPen, this.p1, this.p2);
        }

        public override void Fill(Graphics myGp, Brush br)
        {
            myGp.DrawLine(new Pen(br), this.p1, this.p2);
        }
    }
}
