using System;

namespace Opp_Assignment
{
    // Base class (Parent)
     class Vehicle
    {
        public string Brand { get; set; }

        public void StartEngine()
        {
            Console.WriteLine($"{Brand} engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine($"{Brand} engine stopped.");
        }
    }

    // Derived class (Single Inheritance)
     class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public void Honk()
        {
            Console.WriteLine($"{Brand} car honks: Beep Beep!");
        }
    }

    // Derived class (Multilevel Inheritance)
     class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Charging the {Brand}'s battery with capacity {BatteryCapacity} kWh.");
        }
    }

    // Another Derived class (Hierarchical Inheritance)
     class Bike : Vehicle
    {
        public bool HasGear { get; set; }

        public void RingBell()
        {
            Console.WriteLine($"{Brand} bike rings the bell: Ring Ring!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Single Inheritance: Vehicle -> Car
            Car myCar = new Car
            {
                Brand = "Toyota",
                NumberOfDoors = 4
            };
            myCar.StartEngine();        // From Vehicle class
            myCar.Honk();               // From Car class
            myCar.StopEngine();         // From Vehicle class

            Console.WriteLine();

            // Multilevel Inheritance: Vehicle -> Car -> ElectricCar
            ElectricCar myElectricCar = new ElectricCar
            {
                Brand = "Tesla",
                NumberOfDoors = 4,
                BatteryCapacity = 100
            };
            myElectricCar.StartEngine();    // From Vehicle class
            myElectricCar.Honk();           // From Car class
            myElectricCar.ChargeBattery();  // From ElectricCar class
            myElectricCar.StopEngine();     // From Vehicle class

            Console.WriteLine();

            // Hierarchical Inheritance: Vehicle -> Bike
            Bike myBike = new Bike
            {
                Brand = "Yamaha",
                HasGear = true
            };
            myBike.StartEngine();           // From Vehicle class
            myBike.RingBell();              // From Bike class
            myBike.StopEngine();            // From Vehicle class
        }
    }
}

