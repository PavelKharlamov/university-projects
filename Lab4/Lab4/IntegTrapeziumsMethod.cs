using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class IntegTrapeziumsMethod // интегрирование методом трапеций
    {
        public static double integTrapeziumsMethodResult(Equation e, double x1, double x2, double n)
        {
            // S = 1/2(a + b) / h - формула площади трапеции

            double x; // основание трапеции (b)
            double s; // площади трапеций
            double result = 0; // сумма площадей трапеций
            double h = (x2 - x1) / n; // высота трапеций (h)

            for (double i = 1; i < n; i++) // находим основания трапеции (a, b) и сумму площадей трапеций. Задаем цикл, равный количеству трапеций
            {
                x = x1 + (i * h); // находим начало трапеции
                             
                s = e.Value(x) * h; // находим значения функции в точках начала и конца трапеций. Получаем значения оснований трапеции (a и b). Считаем площадь

                result += s; // складываем все результаты
            }

            result += (e.Value(x1) + e.Value(x2)) / 2*h;

            return result; // выводим итоговое значение
        }
    }
}
