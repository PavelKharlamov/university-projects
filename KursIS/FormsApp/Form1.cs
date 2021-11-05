using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if ((textBox_Login.Text == "") && (textBox_Password.Text == ""))
            {
                button_Authorization.Enabled = false;
            }

            else          
            {
                button_Authorization.Enabled = true;
            }
        }

        private void button_Exit_Click(object sender, EventArgs e) // Кнопка ВЫХОД
        {
            Application.Exit();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_Login.Text) || String.IsNullOrWhiteSpace(textBox_Password.Text))
            {
                button_Authorization.Enabled = false;
            }
            else
            {
                button_Authorization.Enabled = true;
            }
        }

        private void button_Authorization_Click(object sender, EventArgs e) // Кнопка Авторизации. Переход ко второй форме
        {
            
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand comand = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataSet dataset = new DataSet();
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pavel\Desktop\ВУЗ\III курс\Диск\Проектирование информационных систем\FormsApp\FormsApp\bin\x86\Debug\Kursach.accdb");
            comand.CommandText = @"SELECT * FROM Пользователи WHERE Логин='" + textBox_Login.Text + "'AND Пароль='" + textBox_Password.Text + "';";
            connection.Open();

            comand.Connection = connection;

            adapter.SelectCommand = comand;
            adapter.Fill(dataset, "0");
            int count = dataset.Tables[0].Rows.Count;

            if (count > 0)
            {
                Show();
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
            }

            else
            {
                MessageBox.Show("Не коректный логин или пароль", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Login.Clear();
                textBox_Password.Clear();
            }
        }

        private void textBox_Login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
