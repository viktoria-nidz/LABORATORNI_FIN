using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба2_залік
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Логічні вирази
            //У всіх завданнях даного пункту потрібно вивести логічне значення True, якщо приведений вислів для запропонованих початкових даних є істинним, і значення False у супротивному випадку.Всі числа, для яких вказано кількість цифр(двозначне число, тризначне число і т.д.), вважаються цілими. 
            //1.Перевірити істинність вислову: "Дане ціле число є парним двозначним числом".
            //2.Перевірити істинність вислову: "Дане ціле число є непарним тризначним числом".
            //3.Перевірити істинність вислову: "Серед трьох даних цілих чисел є хоч би одна пара співпадаючих".
            //4.Перевірити істинність вислову: "Серед трьох даних цілих чисел є хоч би одна пара взаємно протилежних".
            //5.Перевірити істинність вислову: "Сума цифр даного тризначного числа є парним числом".
            //6.Перевірити істинність вислову: "Сума двох перших цифр даного чотиризначного числа рівна сумі двох його останніх цифр".

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
