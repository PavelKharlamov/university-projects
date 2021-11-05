using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Ocenki". При необходимости она может быть перемещена или удалена.
            //this.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Ucheniki". При необходимости она может быть перемещена или удалена.
            //this.uchenikiTableAdapter.Fill(this.kursachDataSet.Ucheniki);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) // пункт меню ВЫХОД
        {
            Application.Exit();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
