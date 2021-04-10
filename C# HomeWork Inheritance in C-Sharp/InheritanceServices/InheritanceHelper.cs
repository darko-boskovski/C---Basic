using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;
using ClassLibrary.Enums;

namespace InheritanceServices
{
    public static class InheritanceHelper
    {
        public static void PrintInfo(Car[] cars)
        {
            Console.WriteLine("----------------------------------");
            foreach (Car item in cars)
            {
                Console.WriteLine("----------------------------------");
                item.PrintInfo();
                item.Drive();
                item.Repair();
                Console.WriteLine(item.Type);
                Console.WriteLine("----------------------------------");
            }
            Console.WriteLine("----------------------------------");

        }

        public static void printInfoElectricCars(ElectricCar[] electricCars)
        {
            Console.WriteLine("----------------------------------");
            foreach (ElectricCar item in electricCars)
            {
                Console.WriteLine("----------------------------------");
                item.PrintInfo();
                item.Recharge();
                item.Repair();
                Console.WriteLine(item.EngineType);
                Console.WriteLine(item.MaxSpeed);
                Console.WriteLine("----------------------------------");
            }
            Console.WriteLine("----------------------------------");
        }

        public static void PrintInfoBicycle(Bicycle[] bicyle)
        {
            Console.WriteLine("----------------------------------");
            foreach (Bicycle item in bicyle)
            {
                Console.WriteLine("----------------------------------");
                item.PrintInfo();
                item.Ride();
                item.Repair();
                Console.WriteLine(item.Type);
                Console.WriteLine("----------------------------------");
            }
            Console.WriteLine("----------------------------------");
        }

    }
}
