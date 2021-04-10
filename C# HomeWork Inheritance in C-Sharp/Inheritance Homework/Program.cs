using System;
using ClassLibrary.Models;
using ClassLibrary.Enums;
using InheritanceServices;

namespace Inheritance_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Inheritance!");

            Car car01 = new Car()
            {
                Id = 1,
                Manufacturer = "VolksWagen",
                Model = "Golf",
                NumberOFWheels = 4,
                EngineType = EngineType.Diesel,
                FuelConsuption = 6 / 100,
                NumberOfDoors = 5,
                MaxSpeed = 180,
            };
            Car car02 = new Car()
            {
                Id = 2,
                Manufacturer = "Toyota",
                Model = "Yaris",
                NumberOFWheels = 4,
                EngineType = EngineType.Petrol,
                FuelConsuption = 6 / 100,
                NumberOfDoors = 3,
                MaxSpeed = 170,
            };
            Car car03 = new Car()
            {
                Id = 3,
                Manufacturer = "Honda",
                Model = "Civic",
                NumberOFWheels = 4,
                EngineType = EngineType.Petrol,
                FuelConsuption = 7 / 100,
                NumberOfDoors = 3,
                MaxSpeed = 200,
            };


            Bicycle bicycle01 = new Bicycle()
            {
                Id = 1,
                Manufacturer = "Specialized",
                Model = "Allez Sport",
                NumberOFWheels = 2,
                NumberOfSpeedLevels = 9,
                IsElectric = false
            };
            Bicycle bicycle02 = new Bicycle()
            {
                Id = 2,
                Manufacturer = "Specialized",
                Model = "Turbo Levo Hardtail",
                NumberOFWheels = 2,
                NumberOfSpeedLevels = 10,
                IsElectric = true
            };
            Bicycle bicycle03 = new Bicycle()
            {
                Id = 3,
                Manufacturer = "Trek",
                Model = "Fx 2",
                NumberOFWheels = 2,
                NumberOfSpeedLevels = 24,
                IsElectric = false
            };


            ElectricCar car04 = new ElectricCar()
            {
                Id = 1,
                Manufacturer = "Toyota",
                Model = "Prius",
                NumberOFWheels = 4,
                FuelConsuption = 0,
                NumberOfDoors = 5,
                MaxSpeed = 180,
                BatteryCapacity = 8.8,
                BatteryPercentage = 15,
            };

            ElectricCar car05 = new ElectricCar()
            {
                Id = 1,
                Manufacturer = "Tesla",
                Model = "Model 3",
                NumberOFWheels = 4,
                FuelConsuption = 0,
                NumberOfDoors = 5,
                MaxSpeed = 225,
                BatteryCapacity = 50,
                BatteryPercentage = 70,
            };


            Car[] carArray = new Car[] { car01, car02, car03 };
            ElectricCar[] electricCarsArray = new ElectricCar[] { car04, car05 };
            Bicycle [] bicycleArray = new Bicycle[] { bicycle01, bicycle02, bicycle03 };


            InheritanceHelper.PrintInfo(carArray);
            InheritanceHelper.printInfoElectricCars(electricCarsArray);
            InheritanceHelper.PrintInfoBicycle(bicycleArray);
                


           


            Console.ReadLine();
        }
    }
}
