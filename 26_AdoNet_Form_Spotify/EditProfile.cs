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
    public partial class EditProfile : Form
    {
        public static EditProfile instance;
        public Label lbl2;
        public Label lbl3;
        public EditProfile()
        {
            InitializeComponent();
            instance = this;
            lbl2 = label5;
            lbl3 = label6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = HelpMethods.GetDataQuery($"UPDATE Artists SET Username='{textBox1.Text}' WHERE Username='{label5.Text}';");
            //SELECT U.Id FROM Playlists AS p RIGHT JOIN Users AS u ON p.UserId= u.Id
            //WHERE Username = '{textBox1.Text}' and Password = '{HelpMethods.HashPassword(textBox2.Text)}'

            MessageBox.Show("Uğurla heyata keçirildi.");
            var adminWindows = new EditProfile();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = HelpMethods.GetDataQuery($"UPDATE Artists SET Password='{HelpMethods.HashPassword(textBox2.Text)}' WHERE Password='{HelpMethods.HashPassword(label6.Text)}'");
            
            MessageBox.Show("Uğurla heyata keçirildi.");
            var adminWindows = new EditProfile();
            this.Close();
        }
    }
}
