namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnbackspace = new FontAwesome.Sharp.IconButton();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            txtpin = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.gcash1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(134, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 155);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(115, 188);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 1;
            label1.Text = "095824723851";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 188);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 2;
            label2.Text = "Change Number";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnbackspace);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn1);
            panel1.Location = new Point(-2, 336);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 458);
            panel1.TabIndex = 3;
            // 
            // btnbackspace
            // 
            btnbackspace.FlatAppearance.BorderSize = 0;
            btnbackspace.FlatStyle = FlatStyle.Flat;
            btnbackspace.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnbackspace.IconColor = Color.Black;
            btnbackspace.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbackspace.Location = new Point(377, 368);
            btnbackspace.Name = "btnbackspace";
            btnbackspace.Size = new Size(54, 45);
            btnbackspace.TabIndex = 10;
            btnbackspace.UseVisualStyleBackColor = true;
            btnbackspace.Click += iconButton1_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlLight;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 13.8F);
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(157, 343);
            btn0.Name = "btn0";
            btn0.Size = new Size(167, 112);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlLight;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 13.8F);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(322, 236);
            btn9.Name = "btn9";
            btn9.Size = new Size(167, 112);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlLight;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 13.8F);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(157, 236);
            btn8.Name = "btn8";
            btn8.Size = new Size(167, 112);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlLight;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 13.8F);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(0, 236);
            btn7.Name = "btn7";
            btn7.Size = new Size(167, 112);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlLight;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 13.8F);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(322, 118);
            btn6.Name = "btn6";
            btn6.Size = new Size(167, 112);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlLight;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 13.8F);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(157, 118);
            btn5.Name = "btn5";
            btn5.Size = new Size(167, 112);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlLight;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 13.8F);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(0, 118);
            btn4.Name = "btn4";
            btn4.Size = new Size(167, 112);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlLight;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 13.8F);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(322, 0);
            btn3.Name = "btn3";
            btn3.Size = new Size(167, 112);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlLight;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 13.8F);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(157, 0);
            btn2.Name = "btn2";
            btn2.Size = new Size(167, 112);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlLight;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 13.8F);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(0, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(167, 112);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button1_Click;
            // 
            // txtpin
            // 
            txtpin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpin.Location = new Point(215, 272);
            txtpin.Name = "txtpin";
            txtpin.ReadOnly = true;
            txtpin.Size = new Size(55, 34);
            txtpin.TabIndex = 4;
            txtpin.UseSystemPasswordChar = true;
            txtpin.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(169, 237);
            label3.Name = "label3";
            label3.Size = new Size(152, 21);
            label3.TabIndex = 5;
            label3.Text = "Enter your MPIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(482, 794);
            Controls.Add(label3);
            Controls.Add(txtpin);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.AliceBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox txtpin;
        private Button btn2;
        private Button btn1;
        private Button btn3;
        private Button btn9;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn8;
        private Button btn0;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnbackspace;
    }
}
