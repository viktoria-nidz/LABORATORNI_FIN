using System;
using System.Collections.Generic;

namespace GarageSheih
{
    enum Color
    {
        Red,
        Green,
        Black,
        Yellow
    }
    class Car
    {

        string NameCar;
        private short speed;
        private short GraduationYear;
        private ConsoleColor color;

        public string NameCars
        {
            set { this.NameCar = value.ToUpper(); }
            get { return NameCar; }
        }
        public short MostSpeed
        {
            get { return speed; }
            set { speed = value; }
        }
        public short Year
        {
            get { return GraduationYear; }
            set { GraduationYear = value; }
        }
        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car(string name, ConsoleColor color, short MostSpeed, short year)
        {
            this.NameCar = name;
            this.Color = color;
            this.MostSpeed = MostSpeed;
            this.Year = year;
        }

        public override string ToString()
        {

            return $"Name car: {this.NameCar}, \nYear this car: {this.Year}, \nMax speed this car: {this.speed}, \nColor this car: {this.color}\n";
        }

    }
}