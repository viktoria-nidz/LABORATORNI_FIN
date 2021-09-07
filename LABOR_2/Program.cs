using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABOR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn;
            int nk;
            do
            {
                Console.WriteLine("Enter nn");
                nn = Convert.ToInt32(Console.ReadLine());
            } while (nn < 0);
            do
            {
                Console.WriteLine("Enter nk");
                nk = Convert.ToInt32(Console.ReadLine());
            } while (nk < nn);

            double k = nn;
            double a = 0;
            double res = 0;
            for (int i = nk; i >= nn; i--)
            {
                a = 0;
                a = (Math.Pow(k, 2) + Math.Pow(-1, k) * k - 1) / (Math.Pow(k, 2) + 1);
                res += a;
                if (k <= nk)
                {
                    k++;
                }
            }
            Console.WriteLine("RESULT: " + res);

        }
    }
}
