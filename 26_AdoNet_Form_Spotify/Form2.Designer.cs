namespace _26_AdoNet_Form_Spotify
{
    partial class Form2
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
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(51, 99);
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
            pictureBox1.Location = new Point(51, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 74);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(205, 310);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(82, 28);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(170, 251);
            button1.Name = "button1";
            button1.Size = new Size(153, 42);
            button1.TabIndex = 12;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 170);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 91);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 10;
            label1.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 193);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(213, 42);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 114);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 42);
            textBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(205, 33);
            label5.Name = "label5";
            label5.Size = new Size(84, 32);
            label5.TabIndex = 17;
            label5.Text = "Admin";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(412, 21);
            button2.Name = "button2";
            button2.Size = new Size(53, 29);
            button2.TabIndex = 18;
            button2.Text = "<--";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 430);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
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
        private Button button2;
    }
}