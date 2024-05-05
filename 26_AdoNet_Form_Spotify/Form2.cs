using _26_AdoNet_Form_Spotify.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _26_AdoNet_Form_Spotify
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        //public TextBox tb1;

        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            var adminWindows = new Form1();
            this.Hide();
            adminWindows.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var adminWindows = new RegisterAdmin();
            this.Hide();
            adminWindows.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            var data = HelpMethods.GetDataQuery($"SELECT Id FROM Artists WHERE Username = '{textBox1.Text}' and Password = '{HelpMethods.HashPassword(textBox2.Text)}'");


            
            

            if (data.Rows.Count > 0)
            {
                var adminWindows = new AdminWindow();
                this.Hide();
                adminWindows.Show();
                AdminWindow.instance.lbl1.Text = textBox1.Text;
                AdminWindow.instance.lbl2.Text = textBox2.Text;
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya parolu yalnışdır.");
            }




        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
