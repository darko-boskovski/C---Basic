using ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Car : WheeldVehicle
    {
        public EngineType EngineType { get; set; }

        public int FuelConsuption { get; set; }

        public int NumberOfDoors { get; set; }

        public int MaxSpeed { get; set; }

        public Car()
        {
           Type = "Car";
        }
      
        public virtual void Drive()
        {
            Console.WriteLine($"The {Model} is driving!" );
        }
        public override void Repair()
        {
            Console.WriteLine($"Would you like to repair the {Manufacturer} {Model} Car?");   
        }

    }
}
