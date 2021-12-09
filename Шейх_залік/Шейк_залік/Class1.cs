using System;
using System.Collections.Generic;

namespace GarageSheih
{
    class Garage
    {
        List<Car> cars;
        public Garage()
        {
            cars = new List<Car>();
        }
        public void AddCar(Car c)
        {
            this.cars.Add(c);
        }
        public void DeleteCar(Car c)
        {
            this.cars.Remove(c);
        }
        public Car OurCar(ConsoleColor color)
        {
            for (int i = 0; i < this.cars.Count; i++)
            {
                if (color == this.cars[i].Color)
                {
                    return this.cars[i];
                }
            }
            Console.WriteLine("sorry there is no such car, here is your first car");
            return cars[0];
        }

        public Car OurCar(string name)
        {
            for (int i = 0; i < this.cars.Count; i++)
            {
                if (name == this.cars[i].NameCars)
                {
                    return this.cars[i];
                }
            }
            Console.WriteLine("sorry there is no such car, here is your first car");
            return cars[0];
        }

        public Car OurCar(short year)
        {
            if (year >= 1600)
            {
                for (int i = 0; i < this.cars.Count; i++)
                {
                    if (year == this.cars[i].Year)
                    {
                        return this.cars[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.cars.Count; i++)
                {
                    if (year == this.cars[i].MostSpeed)
                    {
                        return this.cars[i];
                    }
                }
            }
            Console.WriteLine("sorry there is no such car, here is your first car");
            return cars[0];
        }
        public void BringCars()
        {
            ConsoleColor before = Console.BackgroundColor;
            for (int i = 0; i < this.cars.Count; i++)
            {
                Console.BackgroundColor = this.cars[i].Color;
                Console.Write(this.cars[i].ToString());
            }
            Console.BackgroundColor = before;
        }
    }
}