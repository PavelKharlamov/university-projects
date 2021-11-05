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
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }

        public string FileName // имя файла
        {
            get
            {
                string text = textBoxCreateName.Text;
                return text;
            }           
        }

        public int W // ширина
        {
            get
            {
                string text = textBoxCreateWidth.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        public int H // высота
        {
            get
            {
                string text = textBoxCreateWidth.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        bool _canceled = false;
        public bool Canceled
        {
            get { return _canceled; }
        }

        private void buttonCreateOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreateCancel_Click(object sender, EventArgs e)
        {
            Close();
            _canceled = true;
        }
    }
}
