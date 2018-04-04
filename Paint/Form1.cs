using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        enum Mode
        {
            Ellipse,
            Circle,
            Recangle,
            Square,
            Line,
            Bezier,
            Polygon,
            Fill,
            Move,
            Group,
            Clear
        }
        #region
        Painting pnlPainting;
        Pen myPen = new Pen(Brushes.Black);
        List<DrawingShape> lstObject = new List<DrawingShape>();
        DrawingShape myObj;
        Mode mode = Mode.Circle;
        Graphics gp;
        List<int> Group;
        bool Locker;
        int indexSelected= -1;
        int vertices = 5;
        Point startPoint, endPoint;
        bool isPress = false;
        bool isFill = false;
        DRectangle target;

        Bitmap tempbitmap;
        Bitmap mainbitmap;
        #endregion

        private void CreatPainting()
        {
            pnlPainting = new Painting();
            pnlPainting.MouseUp += new MouseEventHandler(pnPainting_MouseUp);
            pnlPainting.MouseDown += new MouseEventHandler(pnPainting_MouseDown);
            pnlPainting.MouseMove += new MouseEventHandler(pnPainting_MouseMove);
            pnlPainting.MouseClick += new MouseEventHandler(pnPainting_MouseClick);
            this.Controls.Add(pnlPainting);
        }
        public Form1()
        {
            InitializeComponent();
            CreatPainting();
            myPen = new Pen(Color.Red);
            mainbitmap = new Bitmap(pnlPainting.Width, pnlPainting.Height);
            gp = Graphics.FromImage(mainbitmap);
            Group = new List<int>();
            myPen.Width = 1;
            
        }



        private void pnPainting_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Locker)
            {
                switch (mode)
                {
                    case Mode.Circle:   myObj = new DCircle();      break;
                    case Mode.Ellipse:  myObj = new DEllipse();     break;
                    case Mode.Line:     myObj = new DLine();        break;
                    case Mode.Recangle: myObj = new DRectangle();   break;
                    case Mode.Square:   myObj = new DSquare();      break;
                    case Mode.Bezier:   myObj = new DBezier();      break;
                    case Mode.Polygon:  myObj = new DPolygon(vertices);     break;
                }
                myObj.PenDraw.DashStyle = myPen.DashStyle;
                myObj.p1 = e.Location;
            }
            else
            {
                if (mode == Mode.Move)
                    // tìm kiếm hình được chọn và điểm bắt đầu
                    for (int i = lstObject.Count - 1; i >= 0; i--)
                        if (lstObject[i].isSelected(e.Location))
                        {
                            indexSelected = i;
                            startPoint = e.Location;
                            break;
                        }
                if (mode == Mode.Group)
                {
                    target = new DRectangle()
                    {
                        PenDraw = new Pen(Color.Black, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot },
                        isFill = false
                    };
                    target.p1 = e.Location;
                }
            }
            this.isPress = true;
        }

        private void pnPainting_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPress)
                if (!Locker)
                {   //Vẽ

                    tempbitmap = (Bitmap)mainbitmap.Clone();
                    Graphics g = Graphics.FromImage(tempbitmap);

                    myObj.p2 = e.Location;
                    myObj.DrawShape(g, myPen, isFill);
                    pnlPainting.BackgroundImage = tempbitmap;

                }
                else
                {   //di chuyển
                    if (mode == Mode.Move && indexSelected != -1)
                    {
                        endPoint = e.Location;
                        tempbitmap = new Bitmap(pnlPainting.Width, pnlPainting.Height);
                        Graphics g = Graphics.FromImage(tempbitmap);

                        if (!isInGroup(indexSelected))
                        {
                            lstObject[indexSelected].MoveShape(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                        }
                        else
                            foreach (int temp in Group)
                            {
                                lstObject[temp].MoveShape(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                            }
                        foreach (DrawingShape temp in lstObject)
                            temp.DrawShape(g);

                        pnlPainting.BackgroundImage = tempbitmap;
                        startPoint = e.Location;
                    }
                    if (mode == Mode.Group)
                    {   //tạo khung group
                        target.p2 = e.Location;
                        tempbitmap = (Bitmap)mainbitmap.Clone();
                        Graphics g = Graphics.FromImage(tempbitmap);
                        target.DrawShape(g);
                        pnlPainting.BackgroundImage = tempbitmap;
                    }
                }
        }

        private void pnPainting_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Locker)
            {// vẽ hình
                if (myObj.p1 == myObj.p2)
                    return;
                else
                {
                    mainbitmap = (Bitmap)tempbitmap.Clone();
                    pnlPainting.BackgroundImage = mainbitmap;
                    this.lstObject.Add(myObj);
                }
            }
            else
            {
                // Kết thúc di chuyển
                if (mode == Mode.Move && indexSelected != -1)
                {
                    mainbitmap = (Bitmap)tempbitmap.Clone();
                    pnlPainting.BackgroundImage = mainbitmap;
                    indexSelected = -1;
                }
                if (mode == Mode.Group)
                {   //tạo vùng group
                    if (target.p1 == target.p2)
                        return;
                    else
                    {
                        mainbitmap = (Bitmap)tempbitmap.Clone();
                        pnlPainting.BackgroundImage = mainbitmap;
                    }
                    for (int i = 0; i < lstObject.Count; i++)
                    {
                        if (lstObject[i].isSelected(target.controlPanel))
                        {
                            Group.Add(i);
                        }
                    }
                }
            }
            this.isPress = false;
        }

        bool isInGroup(int i)
        {
            if (Group== null)
                return false;
            foreach (int temp in Group)
                    if (temp == i)
                         return true;
            return false;
        }
        private void pnPainting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode = Mode.Fill;

            Locker = true;
            if (!isFill)
                isFill = true;
            else
                isFill = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {// Xóa tất cả
            mainbitmap = new Bitmap(pnlPainting.Width, pnlPainting.Height);
            pnlPainting.BackgroundImage = mainbitmap;
            lstObject.Clear();
            indexSelected = -1;
            Group.Clear();
        }

        private void pnPainting_MouseClick(object sender, MouseEventArgs e)
        {
            if (Locker)
                for (int i = lstObject.Count - 1; i >= 0; i--)
                    if (lstObject[i].isSelected(e.Location))
                    {
                        switch (mode)
                        {
                            case Mode.Fill:// tô màu hình
                                {
                                    tempbitmap = new Bitmap(pnlPainting.Width, pnlPainting.Height);
                                    Graphics g = Graphics.FromImage(tempbitmap);

                                    if (lstObject[i].isFill)
                                        lstObject[i].isFill = false;
                                    else
                                        lstObject[i].isFill = true;

                                    lstObject[i].PenDraw.Color = myPen.Color;

                                    foreach (DrawingShape temp in lstObject)
                                        temp.DrawShape(g);
                                    mainbitmap = tempbitmap;
                                    pnlPainting.BackgroundImage = mainbitmap;
                                }
                                break;
                            case Mode.Clear:// xóa một hình
                                {
                                    lstObject.RemoveAt(i);
                                    tempbitmap = new Bitmap(pnlPainting.Width, pnlPainting.Height);
                                    Graphics g = Graphics.FromImage(tempbitmap);
                                    foreach (DrawingShape temp in lstObject)
                                        temp.DrawShape(g);
                                    mainbitmap = (Bitmap)tempbitmap.Clone();
                                    pnlPainting.BackgroundImage = mainbitmap;
                                }
                                break;
                        }
                        return;
                    }
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Locker = false;
            mode = Mode.Circle;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            Locker = false;

            mode = Mode.Ellipse;
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            Locker = false;

            mode = Mode.Recangle;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Locker = false;

            mode = Mode.Square;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            Locker = false;

            mode = Mode.Line;
        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            Locker = false;

            mode = Mode.Bezier;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Tomato;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.DeepPink;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Lime;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Green;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Teal;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Yellow;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Black;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.DimGray;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.DarkViolet;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.DarkBlue;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Sienna;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Locker = true;
            mode = Mode.Move;
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            mode = Mode.Group;
            Group = new List<int>();
            Locker = true;
        }

        private void nmrPenWitch_ValueChanged(object sender, EventArgs e)
        {
            myPen.Width = (float)nmrPenWitch.Value;
        }

        private void cbbDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbDashStyle.SelectedIndex)
            {
                case 0: myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;break;
                case 1: myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot; break;
                case 2: myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot; break;
            }
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            mode = Mode.Polygon;
            Locker = false;
            lblVertices.Visible = true;
            txtVertices.Visible = true;
            txtVertices.Enabled = true;
            txtVertices.Focus();
        }

        private void txtVertices_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vertices = Int16.Parse(txtVertices.Text);
            }
            catch
            {
                MessageBox.Show("Mời nhập đúng số đỉnh!");
            }
        }

        private void txtVertices_Leave(object sender, EventArgs e)
        {
            txtVertices.Enabled = false;
            txtVertices.Visible = false;
            lblVertices.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Locker = true;
            mode = Mode.Clear;
        }
    }


}
