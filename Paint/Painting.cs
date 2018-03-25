using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class Painting: Panel
    {
        public Painting():base()
        {
            DoubleBuffered = true;
            Size = new System.Drawing.Size(800, 350);
            Location = new System.Drawing.Point(10, 135);
            BackColor = Color.White;
        }
    }
}
