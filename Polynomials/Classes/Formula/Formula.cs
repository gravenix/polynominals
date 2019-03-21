using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomials.Classes.Formula
{
    class Formula
    {
        private Monomial[] monomials;

        public Formula(Monomial[] m)
        {
            monomials = m;
        }

        public double exec(double x)
        {
            double y = 0.0;
            foreach(Monomial monomial in monomials)
            {
                y += monomial.exec(x);
            }
            return y;
        }

    }
}
