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

namespace _26_AdoNet_Form_Spotify
{
    public partial class AllMusicById : Form
    {
        public AllMusicById()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("MusicName", "MusicName");
            dataGridView1.Columns.Add("Category", "Category");
            dataGridView1.Columns.Add("Duration", "Duration");
            dataGridView1.Columns.Add("ArtistFullname", "ArtistFullname");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection("Server=ZEGA;Database=TaskSQL_4;Trusted_Connection=True;Integrated Security=True;");
            conn.Open();
            using SqlCommand cmd = new SqlCommand($"SELECT m.Id AS Id, m.[Name] AS MusicName, c.[Name] AS CategoryName, m.Duration AS Duration, a.[Name] + ' ' + a.Surname AS ArtistFullname FROM Artists AS a RIGHT JOIN Musics AS m ON m.ArtistId = a.Id LEFT JOIN Categories AS c ON c.Id = m.CategoryId WHERE m.Id = {textBox1.Text}", conn);
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
            }
        }
    }
}
