namespace _26_AdoNet_Form_Spotify
{
    partial class Register
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
            label3 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(22, 93);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 15;
            label3.Text = "Spotify";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.imresizer_1714843905326;
            pictureBox1.Image = Properties.Resources.imresizer_1714843905326;
            pictureBox1.InitialImage = Properties.Resources.imresizer_1714843905326;
            pictureBox1.Location = new Point(22, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 74);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(185, 538);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(72, 28);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign In";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 399);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 320);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 10;
            label1.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 422);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(213, 42);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 343);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 42);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 171);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 19;
            label4.Text = "Surname";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 92);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 18;
            label5.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 194);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 42);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(116, 115);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 42);
            textBox4.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 248);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 20;
            label6.Text = "Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(116, 283);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Men";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(212, 283);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Women";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(167, 41);
            label7.Name = "label7";
            label7.Size = new Size(99, 32);
            label7.TabIndex = 23;
            label7.Text = "Register";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.Location = new Point(172, 483);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 24;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 594);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private Button button2;
    }
}