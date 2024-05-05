using _26_AdoNet_Form_Spotify.Helper;
using Microsoft.VisualBasic.ApplicationServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace _26_AdoNet_Form_Spotify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = HelpMethods.GetDataQuery($"SELECT U.Id FROM Playlists AS p RIGHT JOIN Users AS u ON p.UserId= u.Id WHERE Username = '{textBox1.Text}' and Password = '{HelpMethods.HashPassword(textBox2.Text)}'");
            if (data.Rows.Count > 0)
            {
                var adminWindows = new UserWindow();
                this.Hide();
                adminWindows.Show();
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya parolu yalnışdır.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var adminWindows = new Register();
            this.Hide();
            adminWindows.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var adminWindows = new Form2();
            this.Hide();
            adminWindows.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
