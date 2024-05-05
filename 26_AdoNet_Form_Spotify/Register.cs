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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private RadioButton GetRadioButton1()
        {
            return radioButton1;
        }

        private void button1_Click(object sender, EventArgs e, RadioButton radioButton1)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var adminWindows = new Form1();
            this.Hide();
            adminWindows.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
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
            var SendData = HelpMethods.GetData($"INSERT INTO Users VALUES (N'{textBox4.Text}',N'{textBox3.Text}','{textBox1.Text}','{hashedPassword}','{gender}')");

            if (SendData == 0)
            {
                MessageBox.Show("Xəta baş verdi");
            }
            else
            {
                MessageBox.Show("Uğurla qeydiyyatdan keçirildi");
                var adminWindows = new Form1();
                this.Hide();
                adminWindows.Show();
            }
        }
    }
}
