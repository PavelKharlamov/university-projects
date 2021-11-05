using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OC_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxName(object sender, EventArgs e)
        {

        }

        private void buttonOK(object sender, EventArgs e)
        {
          //получаем значения текстового поля + отрезаем пробелы по краям;
            string userName = tbName.Text.Trim();
            if (userName.Length < 3) // если длина иени слишком короткая, то ошибка!
            {
                MessageBox.Show("Введите имя пользователя");
            }
            else
            {
                MessageBox.Show("Привет " + userName);
            }
        }

        private void buttonCancel(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
