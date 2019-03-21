using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomials.Classes.Formula
{
    class Monomial
    {
        private double a;
        private int power;

        public Monomial(int power, double param=1.0f)
        {
            a = param;
            this.power = power;
        }

        public double exec(double x)
        {
            return Math.Pow(x, power)*a;
        }
    }
}
