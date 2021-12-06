using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zadanie_1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
        static class BazaDanyh
        {
            public static string host = "caseum.ru";
            public static string port = "33333";
            public static string user_id = "test_user";
            public static string database = "db_test";
            public static string password = "test_pass";
        }
    }
}
