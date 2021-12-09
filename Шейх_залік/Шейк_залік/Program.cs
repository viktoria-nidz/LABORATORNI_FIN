using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSheih
{
    class DopTaskGarage
    {
        static void Main()
        {
            Garage garage = new Garage();
            Car FirstCar = new Car("unlike", ConsoleColor.Yellow, 220, 2021);
            Car SecondCar = new Car("last", ConsoleColor.Gray, 180, 1923);
            Car ThirdCar = new Car("crashed", ConsoleColor.Green, 150, 1978);
            Car ForthCar = new Car("nice", ConsoleColor.Red, 380, 1978);


            garage.AddCar(FirstCar);
            garage.AddCar(SecondCar);
            garage.AddCar(ThirdCar);
            garage.AddCar(ForthCar);

            Car OurCar = garage.OurCar(ConsoleColor.Gray);
            ConsoleColor before = Console.BackgroundColor;
            Console.BackgroundColor = OurCar.Color;
            Console.WriteLine(OurCar);
            Console.BackgroundColor = before;

        }
    }
}