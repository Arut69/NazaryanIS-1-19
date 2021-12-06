using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Library;

namespace Zadanie_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
            private void Form5_Load(object sender, EventArgs e)
            {
             
            }
        class ConnBaza
        { }
        public bool InsertStud(string fiostud, string date)
        { 
            ConnBaza conn2 = new ConnBaza();
            MySqlConnection conn = new MySqlConnection();
            //определяем переменную, хранящую количество вставленных строк
            int InsertCount = 0;
            //Объявляем переменную храняющую результат операции
            bool result = false;
            // открываем соединение
            conn.Open();
            // запросы
            // запрос вставки данных
            string query = $"INSERT INTO t_PraktStud (fioStud, datetimeStud) VALUES ('{fiostud}', '{date}')";
            try
            {
                // объект для выполнения SQL-запроса
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                InsertCount = command.ExecuteNonQuery();
                // закрываем подключение к БД
            }
            catch
            {
                //Если возникла ошибка, то запрос не вставит ни одной строки
                InsertCount = 0;
            }
            finally
            {
                //Но в любом случае, нужно закрыть соединение
                conn.Close();
                //Ессли количество вставленных строк было не 0, то есть вставлена хотя бы 1 строка
                if (InsertCount != 0)
                {
                    //то результат операции - истина
                    result = true;
                }
            }
            //Вернём результат операции, где его обработает алгоритм
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fioStud = textBox1.Text;
            string dateitimeStud = DateTime.Now.ToString("Подключение работает");
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Подключение не работает");
            }
            else
            {
                InsertStud(fioStud, dateitimeStud);
            }
        }
    }
}
