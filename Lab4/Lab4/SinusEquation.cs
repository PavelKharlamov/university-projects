using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class SinusEquation : Equation // Sin
    {
        //delegate double operation(double a, double x, double sin);

        double a;

        public SinusEquation(double a) // конструктор
        {
            this.a = a;
        }

        public override double Value(double x) // уравнение
        {
            double sin = Math.Sin(a * x) / x;
            return sin;
        }
    }
}
