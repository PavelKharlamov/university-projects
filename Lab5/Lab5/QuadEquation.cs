using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class QuadEquation : Equation // квадратное уравнение
    {
        double a;
        double b;
        double c;

        public QuadEquation(double a, double b, double c) // конструктор
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Value(double x) // уравнение
        {
            double q = (a * x * x) + (b * x) + c;
            return q;
        }
    }
}
