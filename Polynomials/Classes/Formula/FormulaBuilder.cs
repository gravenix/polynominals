using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomials.Classes.Formula
{
    static class FormulaBuilder
    {
        public static Formula BuildFromText(String formula)
        {
            String[] monomialsString = formula.Split('+');
            Monomial[] monomials = new Monomial[monomialsString.Length];
            for (int i = 0; i<monomialsString.Length; i++){
                String[] tmp = monomialsString[i].Split(new string[] { "*x^" }, StringSplitOptions.None);
                if (tmp.Length > 1)
                {
                    monomials[i] = new Monomial(Convert.ToInt32(tmp[1]), Convert.ToDouble(tmp[0]));
                }
                else
                {
                    monomials[i] = new Monomial(0, 0);
                }
            }
            return new Formula(monomials);
        }
    }
}
