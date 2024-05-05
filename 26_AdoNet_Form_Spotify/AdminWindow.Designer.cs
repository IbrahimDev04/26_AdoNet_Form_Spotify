namespace _26_AdoNet_Form_Spotify
{
    partial class AdminWindow
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
            components = new System.ComponentModel.Container();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuContainer = new FlowLayoutPanel();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button8 = new Button();
            button1 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(1150, 78);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 9;
            label3.Text = "Spotify";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.imresizer_1714843905326;
            pictureBox1.Image = Properties.Resources.imresizer_1714843905326;
            pictureBox1.InitialImage = Properties.Resources.imresizer_1714843905326;
            pictureBox1.Location = new Point(1150, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 63);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(573, 12);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 11;
            label1.Text = "brhma016";
            label1.Click += label1_Click_1;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = SystemColors.ButtonFace;
            menuContainer.Controls.Add(button2);
            menuContainer.Controls.Add(button5);
            menuContainer.Controls.Add(button6);
            menuContainer.Controls.Add(button7);
            menuContainer.Controls.Add(button9);
            menuContainer.Controls.Add(button8);
            menuContainer.Controls.Add(button1);
            menuContainer.Location = new Point(12, 12);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(283, 63);
            menuContainer.TabIndex = 13;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.imresizer_1714918434803;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(90, 57);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 192, 0);
            button5.Font = new Font("Segoe UI Symbol", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(3, 66);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 0, 0);
            button5.Size = new Size(280, 96);
            button5.TabIndex = 19;
            button5.Text = "Edit Profile";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 192, 0);
            button6.Font = new Font("Segoe UI Symbol", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(3, 168);
            button6.Name = "button6";
            button6.Padding = new Padding(15, 0, 0, 0);
            button6.Size = new Size(280, 96);
            button6.TabIndex = 21;
            button6.Text = "Update data";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 192, 0);
            button7.Font = new Font("Segoe UI Symbol", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(3, 270);
            button7.Name = "button7";
            button7.Padding = new Padding(15, 0, 0, 0);
            button7.Size = new Size(280, 96);
            button7.TabIndex = 22;
            button7.Text = "Add Music";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(0, 192, 0);
            button9.Font = new Font("Segoe UI Symbol", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(3, 372);
            button9.Name = "button9";
            button9.Padding = new Padding(15, 0, 0, 0);
            button9.Size = new Size(280, 96);
            button9.TabIndex = 24;
            button9.Text = "Get Music By Id";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 192, 0);
            button8.Font = new Font("Segoe UI Symbol", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(3, 474);
            button8.Name = "button8";
            button8.Padding = new Padding(15, 0, 0, 0);
            button8.Size = new Size(280, 96);
            button8.TabIndex = 23;
            button8.Text = "Sign up";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI Symbol", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 576);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 0, 0);
            button1.Size = new Size(280, 96);
            button1.TabIndex = 25;
            button1.Text = "Exit";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 1;
            menuTransition.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 9);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 14;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(336, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(871, 496);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(985, 180);
            button3.Name = "button3";
            button3.Size = new Size(210, 44);
            button3.TabIndex = 16;
            button3.Text = "Get All Music";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AdminWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 748);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuContainer);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "AdminWindow";
            Text = "AdminWindow";
            Load += AdminWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox Menu;
        private FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Timer menuTransition;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button2;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
    }
}