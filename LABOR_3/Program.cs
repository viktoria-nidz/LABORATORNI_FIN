using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABOR_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, x2, y2;
            do
            {
                Console.WriteLine("Enter the koordinate x for the first field:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the koordinate y for the first field:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the koordinate x for the second field:");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the koordinate y for the second field:");
                y2 = Convert.ToInt32(Console.ReadLine());
            } while (x < 0 || x > 8 || x2 < 0 || x2 > 8 || y < 0 || y > 8 || y2 < 0 || y2 > 8);
            bool check = true;
            if (x == x2 || y == y2)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

        }
    }
}
