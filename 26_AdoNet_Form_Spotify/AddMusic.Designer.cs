namespace _26_AdoNet_Form_Spotify
{
    partial class AddMusic
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 11;
            label3.Text = "Spotify";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.imresizer_1714843905326;
            pictureBox1.Image = Properties.Resources.imresizer_1714843905326;
            pictureBox1.InitialImage = Properties.Resources.imresizer_1714843905326;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 63);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 117);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 40);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 92);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 13;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 183);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 40);
            textBox2.TabIndex = 14;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(148, 255);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 40);
            textBox4.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 160);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 17;
            label2.Text = "Duration";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 232);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 19;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(182, 22);
            label6.Name = "label6";
            label6.Size = new Size(139, 35);
            label6.TabIndex = 20;
            label6.Text = "Add Music";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(197, 314);
            button1.Name = "button1";
            button1.Size = new Size(104, 45);
            button1.TabIndex = 21;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 412);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 22;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // AddMusic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 430);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "AddMusic";
            Text = "AddMusic";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label2;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label4;
    }
}