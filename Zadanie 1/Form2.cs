using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
            static class BazaDanyh
            {
            public static string host = "caseum.ru";
            public static string port = "33333";
            public static string user_id = "test_user";
            public static string database = "db_test";
            public static string password = "test_pass";

            public static string sqlconn()
            {
                string conn = $"server={host};port={port};user={user_id};database={database};password={password}";
                return conn;
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conec = new MySqlConnection(BazaDanyh.sqlconn());
            try
            {
                conec.Open();
                MessageBox.Show("База данных подключена");
            }
            catch
            {
                conec.Close();
            }
        }
    }
}

