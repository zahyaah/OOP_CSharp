using System;

namespace FirstVersion
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    class Car : Vehicle
    {
        public Car(string brand, int speed) : base(brand, speed) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("This is a car.");
        }
    }

    class Bike : Vehicle
    {
        public Bike(string brand, int speed) : base(brand, speed) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("This is a bike.");
        }
    }
}