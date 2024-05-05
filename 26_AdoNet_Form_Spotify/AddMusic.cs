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
    public partial class AddMusic : Form
    {
        public static AddMusic instance;
        public Label lbl2;
        public AddMusic()
        {
            InitializeComponent();
            instance = this;
            lbl2 = label6;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SendData = HelpMethods.GetData($"DECLARE @ID INT SET @ID =(Select Id from Artists where Username='{label6.Text}')INSERT INTO Musics VALUES ('{textBox1.Text}', '{textBox2.Text}', @Id, {textBox4.Text})");
            if (SendData == 0)
            {
                MessageBox.Show("Xəta baş verdi");
            }
            else
            {
                MessageBox.Show("Musiqi elave edildi");
                this.Refresh();
            }
        }
    }
}
