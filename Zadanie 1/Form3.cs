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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private MySqlConnection conn;
        private string connStr = ("server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;");
        //Получение данных из источника базы данных.
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        //Обеспечение доступа к источнику данных.
        private BindingSource bSource = new BindingSource();
        //Ограничение данных и связь между таблицами.
        private DataSet ds = new DataSet();
        //Таблица данных в памяти.
        private DataTable table = new DataTable();
        //Значение Null.

        private void Form3_Load(object sender, EventArgs e)
        {
            // строка подключения к БД
            string connStr = "server=caseum.ru;port=33333;user=test_user;" +
                "database=db_test;password=test_pass;";
            // создаём объект для подключения к БД
            conn = new MySqlConnection(connStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string commandStr = "Выбор айди студента 'Код студента', ФИО студента 'ФИО', " + " Тема курсовой рабоыт студента 'Тема курсовой' Выбор студента";
                //Открываем соединение.
                conn.Open();
                //Запрос в соединение conn.
                MyDA.SelectCommand = new MySqlCommand(commandStr, conn);
                //Заполнение таблиц из БД.
                MyDA.Fill(table);
                //Указываем на источник.
                bSource.DataSource = table;
                //Указываем на источник.
                dataGridView1.DataSource = bSource;
                //Направояем dataGridView1 в правильное русло.
                conn.Close();
                //Закрываем соединение.
            }
            catch
            {
                MessageBox.Show($"База данных не подключена");
            }
            finally
            {
                MessageBox.Show("База данных подключена");
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
