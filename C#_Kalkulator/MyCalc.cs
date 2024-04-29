using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALKULATOR
{
    internal class MyCalc
    {

        public double operasi1 { get; set; }

        public double operasi2 { get; set; }

        public double calc(String opr)
        {
            double result = 0;

            switch (opr)
            {
                case "+":
                    result = operasi1 + operasi2;
                    break;
                case "-":
                    result = operasi1 - operasi2;
                    break;
                case "*":
                    result = operasi1 * operasi2;
                    break;
                case "/":
                    result = operasi1 / operasi2;
                    break;
            }
            return result;
        }

        public double calc(double o1, string tanda, double o2)
        {
            double result = 0;

            operasi1 = o1;
            operasi2 = o2;

            result = calc(tanda);
            return result;
        }
    }
}
