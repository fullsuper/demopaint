using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    class LabelShape : Label
    {
        Graphics gp;
        public LabelShape()
        {
            
            gp = this.CreateGraphics();
        }
        public void DrawShape()
        {
            
            gp.FillRectangle(Brushes.Black, 0, 0, this.Width, this.Height);
            

        }

    }
}
