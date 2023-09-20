using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class AckleyFuncion
    {
        public static double Calculate(double[] x)
        {
            int n = x.Length;
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                sum1 += x[i] * x[i];
                sum2 += Math.Cos(2 * Math.PI * x[i]);
            }

            double term1 = -20 * Math.Exp(-0.2 * Math.Sqrt(sum1 / n));
            double term2 = -Math.Exp(sum2 / n);

            double result = term1 + term2 + 20 + Math.E;
            return result;
        }
    }
}
