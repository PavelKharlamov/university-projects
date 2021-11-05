using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGO_Click(object sender, EventArgs e) // кнопка "Построить график"
        {
            // конвертируем заданные числа из string в double
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double c = Convert.ToDouble(textBoxC.Text);
            double x1 = Convert.ToDouble(textBoxX1.Text);
            double x2 = Convert.ToDouble(textBoxX2.Text);
            double n = Convert.ToDouble(textBoxStepN.Text);

            // очищаем график (чтобы новые графики не накладывались друг на друга)
            chartQuadEquation.Series[0].Points.Clear();
            chartSinEquation.Series[0].Points.Clear();

            QuadEquation f1 = new QuadEquation(a, b, c); // функция квадратного уравнения
            SinusEquation f2 = new SinusEquation(a); // функция Sin

            for (double x = x1; x <= x2; x += 1) // цикл для построения графика
            {
                chartQuadEquation.Series[0].Points.AddXY(x, f1.Value(x)); // значения квадратного уравнения
                chartSinEquation.Series[0].Points.AddXY(x, f2.Value(x)); // значения Sin
            }

            // выводим результаты интегрирования методом прямоугольников

            // для квадратного уравнения
            double integRectanglesQuad = IntegRectanglesMethod.integRectanglesMethodResult(f1, x1, x2, n);
            textBoxIntegRectanglesQuadEquation.Text = Convert.ToString(integRectanglesQuad);

            // для Sin
            double integRectanglesSinus = IntegRectanglesMethod.integRectanglesMethodResult(f2, x1, x2, n);
            textBoxIntegRectanglesSinusEquation.Text = Convert.ToString(integRectanglesSinus);


            // выводим результаты интегрирования методом трапеций

            // для квадратного уравнения
            double integTrapeziumsQuad = IntegTrapeziumsMethod.integTrapeziumsMethodResult(f1, x1, x2, n);
            textBoxIntegTrapeziumsQuadEquation.Text = Convert.ToString(integTrapeziumsQuad);

            // для Sin
            double integTrapeziumsSinus = IntegTrapeziumsMethod.integTrapeziumsMethodResult(f2, x1, x2, n);
            textBoxIntegTrapeziumsSinusEquation.Text = Convert.ToString(integTrapeziumsSinus);
        }
    }
}
