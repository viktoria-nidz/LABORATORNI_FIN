using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORNI_FIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            double radius;
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hight:");
            double hight;
            hight = Convert.ToDouble(Console.ReadLine());
            double volume;
            const double PI = 3.14;
            volume = (Math.Pow(radius, 2) * hight * PI) * 1 / 3;
            Console.WriteLine("the volume of the cone: " + volume);

        }
    }
}
