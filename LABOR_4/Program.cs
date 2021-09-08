using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABOR_4
{
    class Program
    {
        static void Main()
        {
            int N = 6;
            int[] array = new int[N];
            for (int i=0; i<N;i++)
            {
                Console.WriteLine("Enter an element of the array:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            double R;
            double closest_numb=0;
            double remotest_numb=0;
            double how_close = 1000000;
            double how_remote = 0;
            Console.WriteLine("Enter  R:");
            R = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                if(array[i]==R)
                {

                    closest_numb =R;
                    how_remote = 0;
                }
              if (array[i]>R)
                {
                if(array[i]-R>how_remote)
                    {
                        remotest_numb= array[i];
                        how_remote = array[i] - R;
                    }
                if (array[i]-R<how_close)
                    {
                        closest_numb = array[i];
                        how_close = array[i] - R;
                    }
                }
                   if (array[i]<R)
                {
                    if (-array[i] + R > how_remote)
                    {
                         remotest_numb= array[i];
                        how_remote = -array[i] + R;
                    }
                    if (-array[i] + R < how_close)
                    {
                        closest_numb = array[i];
                        how_close = -array[i] + R;
                    }
                }

            }
                   

            
            Console.WriteLine("remote:"+remotest_numb);
            Console.WriteLine("close:"+closest_numb);

        }
    }
}
