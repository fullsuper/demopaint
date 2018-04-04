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
            Size = new System.Drawing.Size(940, 420);
            Location = new System.Drawing.Point(10, 135);
            BackColor = Color.White;
        }
    }
}
