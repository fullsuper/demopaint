namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnBezier = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbbDashStyle = new System.Windows.Forms.ComboBox();
            this.nmrPenWitch = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPenWitch)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(467, 13);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(110, 55);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Xóa tất cả";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCircle.BackgroundImage = global::Paint.Properties.Resources.US_I_Corps_svg;
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCircle.Location = new System.Drawing.Point(232, 12);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(55, 55);
            this.btnCircle.TabIndex = 6;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEllipse.BackgroundImage = global::Paint.Properties.Resources.ellipse;
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEllipse.Location = new System.Drawing.Point(232, 62);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(55, 55);
            this.btnEllipse.TabIndex = 6;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSquare.BackgroundImage")));
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSquare.ForeColor = System.Drawing.Color.Transparent;
            this.btnSquare.Location = new System.Drawing.Point(283, 62);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(55, 55);
            this.btnSquare.TabIndex = 6;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRec
            // 
            this.btnRec.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRec.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.btnRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRec.Location = new System.Drawing.Point(283, 12);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(55, 55);
            this.btnRec.TabIndex = 6;
            this.btnRec.UseVisualStyleBackColor = false;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLine.BackgroundImage = global::Paint.Properties.Resources.line_icon_61713;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLine.Location = new System.Drawing.Point(334, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(55, 55);
            this.btnLine.TabIndex = 6;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBezier.BackgroundImage = global::Paint.Properties.Resources.bezier;
            this.btnBezier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBezier.Location = new System.Drawing.Point(334, 62);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(55, 55);
            this.btnBezier.TabIndex = 6;
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(521, 65);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(110, 55);
            this.btnGroup.TabIndex = 6;
            this.btnGroup.Text = "Nhóm";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(415, 65);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(55, 55);
            this.btnMove.TabIndex = 6;
            this.btnMove.Text = "Đi";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Green;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button8.FlatAppearance.BorderSize = 5;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(75, 33);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DimGray;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button12.FlatAppearance.BorderSize = 5;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.Location = new System.Drawing.Point(75, 62);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 30);
            this.button12.TabIndex = 7;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Black;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button17.FlatAppearance.BorderSize = 5;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button17.Location = new System.Drawing.Point(17, 62);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(30, 30);
            this.button17.TabIndex = 7;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Teal;
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button21.FlatAppearance.BorderSize = 5;
            this.button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button21.Location = new System.Drawing.Point(103, 33);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(30, 30);
            this.button21.TabIndex = 7;
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Red;
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button22.FlatAppearance.BorderSize = 5;
            this.button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button22.Location = new System.Drawing.Point(46, 62);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(30, 30);
            this.button22.TabIndex = 7;
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.DarkViolet;
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button23.FlatAppearance.BorderSize = 5;
            this.button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button23.Location = new System.Drawing.Point(103, 62);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(30, 30);
            this.button23.TabIndex = 7;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Tomato;
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button24.FlatAppearance.BorderSize = 5;
            this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button24.Location = new System.Drawing.Point(132, 33);
            this.button24.Name = "button24";
            this.button24.Padding = new System.Windows.Forms.Padding(1);
            this.button24.Size = new System.Drawing.Size(30, 30);
            this.button24.TabIndex = 7;
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.DeepPink;
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button25.FlatAppearance.BorderSize = 5;
            this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button25.Location = new System.Drawing.Point(17, 33);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(30, 30);
            this.button25.TabIndex = 7;
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Yellow;
            this.button26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button26.FlatAppearance.BorderSize = 5;
            this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button26.Location = new System.Drawing.Point(160, 33);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(30, 30);
            this.button26.TabIndex = 7;
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.DarkBlue;
            this.button27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button27.FlatAppearance.BorderSize = 5;
            this.button27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button27.Location = new System.Drawing.Point(132, 62);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(30, 30);
            this.button27.TabIndex = 7;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Lime;
            this.button28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button28.FlatAppearance.BorderSize = 5;
            this.button28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button28.Location = new System.Drawing.Point(46, 33);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(30, 30);
            this.button28.TabIndex = 7;
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Sienna;
            this.button29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button29.FlatAppearance.BorderSize = 5;
            this.button29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button29.Location = new System.Drawing.Point(160, 62);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(30, 30);
            this.button29.TabIndex = 7;
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Controls.Add(this.button24);
            this.groupBox1.Controls.Add(this.button29);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button28);
            this.groupBox1.Controls.Add(this.button25);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Controls.Add(this.button27);
            this.groupBox1.Controls.Add(this.button26);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(207, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "    Màu sắc    ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(468, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 55);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbbDashStyle
            // 
            this.cbbDashStyle.FormattingEnabled = true;
            this.cbbDashStyle.Items.AddRange(new object[] {
            "Liền",
            "Nét đứt",
            "Đứt chấm chấm"});
            this.cbbDashStyle.Location = new System.Drawing.Point(661, 25);
            this.cbbDashStyle.Name = "cbbDashStyle";
            this.cbbDashStyle.Size = new System.Drawing.Size(121, 32);
            this.cbbDashStyle.TabIndex = 8;
            this.cbbDashStyle.SelectedIndexChanged += new System.EventHandler(this.cbbDashStyle_SelectedIndexChanged);
            // 
            // nmrPenWitch
            // 
            this.nmrPenWitch.Location = new System.Drawing.Point(661, 88);
            this.nmrPenWitch.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrPenWitch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrPenWitch.Name = "nmrPenWitch";
            this.nmrPenWitch.Size = new System.Drawing.Size(50, 29);
            this.nmrPenWitch.TabIndex = 9;
            this.nmrPenWitch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrPenWitch.ValueChanged += new System.EventHandler(this.nmrPenWitch_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Độ dày";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(962, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrPenWitch);
            this.Controls.Add(this.cbbDashStyle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnBezier);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrPenWitch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbbDashStyle;
        private System.Windows.Forms.NumericUpDown nmrPenWitch;
        private System.Windows.Forms.Label label1;
    }
}

