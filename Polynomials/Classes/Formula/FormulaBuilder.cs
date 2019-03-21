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
            formula = formula.Replace("-", "+-");
            String[] monomialsString = formula.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
            Monomial[] monomials = new Monomial[monomialsString.Length];
            for (int i = 0; i<monomialsString.Length; i++){
                String[] tmp = monomialsString[i].Split('x');
                if (tmp.Length == 1) tmp = new String[] { tmp[0], "0" };
                tmp[0] = tmp[0].Replace("*", "");
                tmp[0] = tmp[0].Replace(".", ",");
                if (tmp[0].Length == 0) tmp[0] = "1";
                else if (tmp[0].ElementAt(0) == '-') tmp[0] = "-1";
                tmp[1] = tmp[1].Replace("^", "");
                if (tmp[1].Length == 0) tmp[1] = "1";
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
