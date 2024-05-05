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

namespace _26_AdoNet_Form_Spotify
{
    public partial class RegisterAdmin : Form
    {
        public RegisterAdmin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var adminWindows = new Form2();
            this.Hide();
            adminWindows.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender;

            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }



            string hashedPassword = HelpMethods.HashPassword(textBox2.Text);
            var SendData = HelpMethods.GetData($"INSERT INTO Artists VALUES (N'{textBox4.Text}',N'{textBox3.Text}','{dateTimePicker1.MinDate.Day}/{dateTimePicker1.MinDate.Month}/{dateTimePicker1.MinDate.Year}','{gender}','{textBox1.Text}','{hashedPassword}')");

            if (SendData == 0)
            {
                MessageBox.Show("Xəta baş verdi");
            }
            else
            {
                MessageBox.Show("Uğurla qeydiyyatdan keçirildi");
                var adminWindows = new Form2();
                this.Hide();
                adminWindows.Show();
            }
        }
    }
}
