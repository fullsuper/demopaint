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
            this.pnPainting = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rdCircle = new System.Windows.Forms.RadioButton();
            this.rdSquare = new System.Windows.Forms.RadioButton();
            this.rdEllipse = new System.Windows.Forms.RadioButton();
            this.rdRec = new System.Windows.Forms.RadioButton();
            this.rdBezier = new System.Windows.Forms.RadioButton();
            this.rdLine = new System.Windows.Forms.RadioButton();
            this.grShape = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPainting
            // 
            this.pnPainting.BackColor = System.Drawing.Color.White;
            this.pnPainting.Location = new System.Drawing.Point(9, 137);
            this.pnPainting.Margin = new System.Windows.Forms.Padding(0);
            this.pnPainting.Name = "pnPainting";
            this.pnPainting.Size = new System.Drawing.Size(800, 350);
            this.pnPainting.TabIndex = 0;
            this.pnPainting.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPainting_Paint);
            this.pnPainting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnPainting_MouseClick);
            this.pnPainting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnPainting_MouseDown);
            this.pnPainting.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnPainting_MouseMove);
            this.pnPainting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnPainting_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdCircle
            // 
            this.rdCircle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdCircle.BackColor = System.Drawing.Color.Transparent;
            this.rdCircle.BackgroundImage = global::Paint.Properties.Resources.US_I_Corps_svg;
            this.rdCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdCircle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCircle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdCircle.Location = new System.Drawing.Point(25, 25);
            this.rdCircle.Margin = new System.Windows.Forms.Padding(0);
            this.rdCircle.Name = "rdCircle";
            this.rdCircle.Size = new System.Drawing.Size(50, 50);
            this.rdCircle.TabIndex = 2;
            this.rdCircle.Text = "  ";
            this.rdCircle.UseVisualStyleBackColor = false;
            // 
            // rdSquare
            // 
            this.rdSquare.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSquare.Image = global::Paint.Properties.Resources.images;
            this.rdSquare.Location = new System.Drawing.Point(73, 73);
            this.rdSquare.Name = "rdSquare";
            this.rdSquare.Size = new System.Drawing.Size(50, 50);
            this.rdSquare.TabIndex = 2;
            this.rdSquare.UseVisualStyleBackColor = true;
            // 
            // rdEllipse
            // 
            this.rdEllipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdEllipse.BackgroundImage = global::Paint.Properties.Resources.ellipse;
            this.rdEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEllipse.Location = new System.Drawing.Point(25, 73);
            this.rdEllipse.Name = "rdEllipse";
            this.rdEllipse.Size = new System.Drawing.Size(50, 50);
            this.rdEllipse.TabIndex = 2;
            this.rdEllipse.UseVisualStyleBackColor = true;
            // 
            // rdRec
            // 
            this.rdRec.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdRec.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.rdRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdRec.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRec.Location = new System.Drawing.Point(73, 25);
            this.rdRec.Margin = new System.Windows.Forms.Padding(0);
            this.rdRec.Name = "rdRec";
            this.rdRec.Size = new System.Drawing.Size(50, 50);
            this.rdRec.TabIndex = 2;
            this.rdRec.Text = "  ";
            this.rdRec.UseVisualStyleBackColor = true;
            // 
            // rdBezier
            // 
            this.rdBezier.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBezier.BackgroundImage = global::Paint.Properties.Resources.bezier;
            this.rdBezier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdBezier.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdBezier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBezier.Location = new System.Drawing.Point(120, 73);
            this.rdBezier.Name = "rdBezier";
            this.rdBezier.Size = new System.Drawing.Size(50, 50);
            this.rdBezier.TabIndex = 2;
            this.rdBezier.UseVisualStyleBackColor = true;
            // 
            // rdLine
            // 
            this.rdLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdLine.BackgroundImage = global::Paint.Properties.Resources.line_icon_61713;
            this.rdLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLine.Location = new System.Drawing.Point(120, 25);
            this.rdLine.Name = "rdLine";
            this.rdLine.Size = new System.Drawing.Size(50, 50);
            this.rdLine.TabIndex = 2;
            this.rdLine.UseVisualStyleBackColor = true;
            // 
            // grShape
            // 
            this.grShape.BackColor = System.Drawing.Color.Honeydew;
            this.grShape.Controls.Add(this.rdCircle);
            this.grShape.Controls.Add(this.rdLine);
            this.grShape.Controls.Add(this.rdSquare);
            this.grShape.Controls.Add(this.rdBezier);
            this.grShape.Controls.Add(this.rdEllipse);
            this.grShape.Controls.Add(this.rdRec);
            this.grShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grShape.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grShape.Location = new System.Drawing.Point(12, 1);
            this.grShape.Name = "grShape";
            this.grShape.Padding = new System.Windows.Forms.Padding(0);
            this.grShape.Size = new System.Drawing.Size(346, 123);
            this.grShape.TabIndex = 3;
            this.grShape.TabStop = false;
            this.grShape.Text = "Chọn hình";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(443, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 85);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(571, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "CreateST";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(962, 502);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grShape);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnPainting);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grShape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPainting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdLine;
        private System.Windows.Forms.RadioButton rdRec;
        private System.Windows.Forms.RadioButton rdEllipse;
        private System.Windows.Forms.RadioButton rdCircle;
        private System.Windows.Forms.RadioButton rdSquare;
        private System.Windows.Forms.RadioButton rdBezier;
        private System.Windows.Forms.GroupBox grShape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

