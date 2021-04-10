using ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Bicycle:WheeldVehicle
    {
        public int NumberOfSpeedLevels { get; set; }

        public bool IsElectric { get; set; }
        public Bicycle()
        {
            Type = "Bicycle";
        }

        public void Ride()
        {
            Console.WriteLine("The Bicycle is being riden!");
        }

        public override void Repair()
        {
            Console.WriteLine("The bicycle was successfully reapired");
        }
    }
}
