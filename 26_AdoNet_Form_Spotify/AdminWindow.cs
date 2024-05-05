using _26_AdoNet_Form_Spotify.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _26_AdoNet_Form_Spotify
{
    public partial class AdminWindow : Form
    {
        EditProfile editProfile;
        AddMusic addMusic;
        AllMusicById getMusic;

        public static AdminWindow instance;
        public Label lbl1;
        public Label lbl2;

        public AdminWindow()
        {

            InitializeComponent();

            instance = this;
            lbl1 = label1;
            lbl2 = label2;

            dataGridView1.Columns.Add("ArtistFullname", "ArtistFullname");
            dataGridView1.Columns.Add("Gender", "Gender");
            dataGridView1.Columns.Add("MusicName", "MusicName");






        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        bool menuExpand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 670)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 63)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            editProfile = new EditProfile();

            editProfile.Show();
            this.Refresh();
            EditProfile.instance.lbl2.Text = label1.Text;
            EditProfile.instance.lbl3.Text = label2.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            using SqlConnection conn = new SqlConnection("Server=ZEGA;Database=TaskSQL_4;Trusted_Connection=True;Integrated Security=True;");
            conn.Open();
            using SqlCommand cmd = new SqlCommand($"SELECT a.[Name] + ' ' + a.Surname AS ArtistFullname, a.Gender AS Gender, m.[Name] As MusicName FROM Artists AS a RIGHT JOIN Musics AS m ON m.ArtistId=a.Id where a.Username='{label1.Text}'", conn);
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addMusic = new AddMusic();

            addMusic.Show();
            this.Refresh();
            AddMusic.instance.lbl2.Text = label2.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            getMusic = new AllMusicById();

            getMusic.Show();
            this.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
