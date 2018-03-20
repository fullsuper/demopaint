using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        #region
        Graphics gplb;
        Pen myPen = new Pen(Brushes.Black);
        List<DrawingShape> lstObject = new List<DrawingShape>();

        Graphics gp;

        bool isPress = false;
        bool isFill = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
            myPen = new Pen(Color.Red);
            gp = pnPainting.CreateGraphics();
 
        }

        Region re = new Region();


        private void pnPainting_MouseDown(object sender, MouseEventArgs e)
        {
            //if (mode == 0)
            //    return;

            if (rdLine.Checked)
            {
                DrawingShape myObj = new DLine();
                myObj.p1 = e.Location;
                this.lstObject.Add(myObj);
                this.isPress = true;
            }
            if (rdEllipse.Checked)
            {
                DrawingShape myObj = new DEllipse();
                myObj.p1 = e.Location;
                this.lstObject.Add(myObj);
                this.isPress = true;
            }
            if (rdRec.Checked)
            {
                DrawingShape myObj = new DRectangle();
                myObj.p1 = e.Location;
                this.lstObject.Add(myObj);
                this.isPress = true;
            }
            if (rdSquare.Checked)
            {
                DrawingShape myObj = new DSquare();
                myObj.p1 = e.Location;
                this.lstObject.Add(myObj);
                this.isPress = true;
            }
            if (rdCircle.Checked)
            {
                DrawingShape myObj = new DCircle();
                myObj.p1 = e.Location;
                this.lstObject.Add(myObj);
                this.isPress = true;
            }
        }

        private void pnPainting_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isPress == true)
            {
                this.lstObject[this.lstObject.Count - 1].p2 = e.Location;
                gp.Clear(Color.White);
                for (int i = 0; i < lstObject.Count - 1; i++)
                {
                    this.lstObject[i].Draw(this.gp, this.myPen);
                }
                if (!isFill)
                    lstObject[lstObject.Count - 1].Draw(gp, this.myPen);
                else
                    lstObject[lstObject.Count - 1].Fill(gp, this.myPen.Brush);

            }

        }

        private void pnPainting_MouseUp(object sender, MouseEventArgs e)
        {
            this.isPress = false;
            this.lstObject[this.lstObject.Count - 1].p2 = e.Location;
            if (!isFill)
                for (int i = 0; i < lstObject.Count - 1; i++)
                {
                    this.lstObject[i].Draw(this.gp, this.myPen);
                }
            else for (int i = 0; i < lstObject.Count - 1; i++)
                {
                    lstObject[i].Fill(gp, this.myPen.Brush);
                }

        }

        private void pnPainting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            gplb = lbl.CreateGraphics();
            gplb.DrawLine(new Pen(Brushes.Black), 0, 0, 30, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isFill = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gp.Clear(Color.Wheat);
            lstObject.Clear();

        }

        private void pnPainting_MouseClick(object sender, MouseEventArgs e)
        {

            for (int i = lstObject.Count - 1; i >= 0; i--)
            {
           
                if (lstObject[i].isSelected(e.Location))
                {
                    MessageBox.Show("hahah");
                    return;
                }
                
            }
        }

    }
}
