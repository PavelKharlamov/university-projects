using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class IntegRectanglesMethod // интегрирование методом прямоугольников
    {
        public static double integRectanglesMethodResult(Equation e, double x1, double x2, double n)
        {
            // S = a * b - формула площади прямоугольника

            double x; // начало прямоугольника
            double s; // площади прямоугольников
            double result = 0; // сумма площадей прямоугольников
            double h = (x2 - x1) / n; // длина прямоугольников (a)

            for (double i = 1; i <= n; i++) // находим сторону (b) и сумму площадей прямоугольников. Задаем цикл, равный количеству прямоугольников
            {
                x = x1 + (i * h); // точка x, разделяющая прямоугольники. При помощи этой точки находится нужное значение функции
                s = e.Value(x) * h; // находим значение функции. Это будет сторона b. Считаем площадь
                result += s; // складываем все результаты
            }

            return result; // выводим итоговое значение
        }
    }
}
