namespace _26_AdoNet_Form_Spotify
{
    partial class AllMusicById
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(23, 78);
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
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 63);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(137, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(634, 337);
            dataGridView1.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(488, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 52);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 39);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 18;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI Historic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(688, 51);
            button1.Name = "button1";
            button1.Size = new Size(64, 52);
            button1.TabIndex = 19;
            button1.Text = "Get";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AllMusicById
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "AllMusicById";
            Text = "AllMusicById";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}