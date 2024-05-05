using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _26_AdoNet_Form_Spotify.Helper
{

    internal class HelpMethods
    {
        const string ConnectingPath = "Server=ZEGA;Database=TaskSQL_4;Trusted_Connection=True;Integrated Security=True;";
        public int Id {  get; set; }

        public HelpMethods(int id)
        {
            Id = id;
        }

        

        public static DataTable GetDataQuery(string query)
        {
            using SqlConnection connecting = new SqlConnection(ConnectingPath);
            connecting.Open();
            using SqlDataAdapter adapter = new SqlDataAdapter(query, connecting);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static int GetData(string query)
        {
            using SqlConnection connecting = new SqlConnection(ConnectingPath);
            connecting.Open();
            using SqlCommand cmd = new SqlCommand(query, connecting);
            return cmd.ExecuteNonQuery();
        }

        public static string HashPassword(string password)
        {
            return Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.Default.GetBytes(password)));
        }
    }
}
