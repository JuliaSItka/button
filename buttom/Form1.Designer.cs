namespace buttom
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.elipseButton1 = new buttom.ElipseButton();
            this.triangleButton1 = new buttom.TriangleButton();
            this.elipseButton2 = new buttom.ElipseButton();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Green",
            "Yellow",
            "Pink",
            "Orange",
            "Violet"});
            this.comboBox1.Location = new System.Drawing.Point(28, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Rectangle",
            "Ellipse",
            "Triangle",
            "Circle"});
            this.comboBox2.Location = new System.Drawing.Point(420, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Form";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(226, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 99);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // elipseButton1
            // 
            this.elipseButton1.Location = new System.Drawing.Point(171, 179);
            this.elipseButton1.Name = "elipseButton1";
            this.elipseButton1.Size = new System.Drawing.Size(261, 87);
            this.elipseButton1.TabIndex = 6;
            this.elipseButton1.UseVisualStyleBackColor = true;
            this.elipseButton1.Visible = false;
            // 
            // triangleButton1
            // 
            this.triangleButton1.Location = new System.Drawing.Point(38, 85);
            this.triangleButton1.Name = "triangleButton1";
            this.triangleButton1.Size = new System.Drawing.Size(383, 187);
            this.triangleButton1.TabIndex = 7;
            this.triangleButton1.UseVisualStyleBackColor = true;
            this.triangleButton1.Visible = false;
            // 
            // elipseButton2
            // 
            this.elipseButton2.Location = new System.Drawing.Point(264, 173);
            this.elipseButton2.Name = "elipseButton2";
            this.elipseButton2.Size = new System.Drawing.Size(100, 100);
            this.elipseButton2.TabIndex = 8;
            this.elipseButton2.UseVisualStyleBackColor = true;
            this.elipseButton2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 314);
            this.Controls.Add(this.elipseButton2);
            this.Controls.Add(this.triangleButton1);
            this.Controls.Add(this.elipseButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ElipseButton elipseButton1;
        private TriangleButton triangleButton1;
        private ElipseButton elipseButton2;
    }
}

