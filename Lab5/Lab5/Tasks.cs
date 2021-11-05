using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab5
{
    public class Tasks
    {
        public string Z1(int n) // Задание №1
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (n < 1 || n > 26)
            {
                throw new System.ArgumentException();
            }

            else
            {
                string alphabet2 = alphabet.Substring(0, n);
                return alphabet2;
            }
        }

        public int Z2(int n) // Задание №2
        {
            int d = 0;                  // количество дней

            if (n % 4 == 0)
            {
                if (n % 100 == 0 && n % 400 != 0) // не високосный
                {
                    d = 365;
                }
                else                              // високосный
                {
                    d = 366;
                }
            }

            else                                  // високосный
            {
                d = 365;
            }

            if (n == 0)
            {
                d = 365; // не високосный
            }

            return d;
        }

        public bool Z3(string n) // Задание №3
        {
            string pattern = @"^[A-Za-z0-9]{3,}@([a-z]{4,}.[a-z]{2,})$";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(n);

            if (match.Success)
            {
                return true;
            }

            else
            {
                throw new System.ArgumentException();
            }
        }

        public int Z4(string n) // Задание №4
        {
            string pattern = @"^\d+";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(n);

            if (match.Success)
            {
                int k = int.Parse(n);

                int sum = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    sum += Convert.ToInt32(n[i].ToString());
                }
                return sum;
            }

            else
            {
                throw new System.FormatException();
            }
        }

        public double Z5(double a, double b, double c, double x1, double x2, double n)
        {
            if (n < 0)
            {
                throw new System.ArgumentException();
            }

            else
            {
                QuadEquation f1 = new QuadEquation(a, b, c); // функция квадратного уравнения

                // выводим результаты интегрирования методом прямоугольников
                // для квадратного уравнения
                double integRectanglesQuad = IntegRectanglesMethod.integRectanglesMethodResult(f1, x1, x2, n);
                double result = Math.Round(integRectanglesQuad, 2);

                return result;
            }          
        }
    }
}
