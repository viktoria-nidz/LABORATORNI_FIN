using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1_залік
{
    class Program
    {

        //      Написати програму, що виконує наступні функції 
        //1.  Виводить на екран введене число з клавіатури в зворотному порядку(1234->4321)
        //2.  Виводить будь-яку строку в зворотному порядку(АБВ->ВБА)
        //3.  Дробові числа виводяться в зворотному порядку і ціла частина і дробова(123.456->321.654)
        //4.  Реалізувати метод, що буде масив повертати задом навпаки(Використання Array.Reverse() заборонено!)
        //5.  Виконати пункт 4 з використанням ключових слів ref i out


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user!");
            Console.WriteLine("If you want to reverse your data, Firstly, you should choose a type:");
            Console.WriteLine("1.INT   2.DOUBLE  3.STR  4.ARR");

            string type = Console.ReadLine();
            if (type == "ARR")
            {
                int[] array = new int[7];

                for (int i = 0; i < array.Length; i++)
                {

                    Console.WriteLine("Please, enter your number: №" + (i + 1));
                    array[i] = int.Parse(Console.ReadLine());

                }
                FIN(ref array, out string final);

                Console.Write(final);
                Console.ReadLine();
            }


            void FIN(ref int[] arr, out string final)
            {
                string result = string.Empty;

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    result += arr[i];
                }

                final = result;
            }


            if (type == "DOUBLE")
            {
                Console.WriteLine("Please, enter your data of this type:");
                string type2= Console.ReadLine();

                string[] separate = type2.Split('.', ',');

                string first = separate[0];
                string second = separate[1];

                for (int i = first.Length - 1; i >= 0; i--)
                {
                    Console.Write(first[i]);

                }
                Console.Write(".");
                for (int i = second.Length - 1; i >= 0; i--)
                {
                    Console.Write(second[i]);

                }
                Console.ReadLine();
            }


            if (type == "STR" || type == "INT")
            {
                Console.WriteLine("Please, enter your data of this type:");
                string type13 = Console.ReadLine();


                for (int i = type13.Length - 1; i >= 0; i--)
                {
                    Console.Write(type13[i]);

                }
                Console.WriteLine("");

            }

           

        }
    }
}