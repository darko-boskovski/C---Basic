using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class WheeldVehicle:Vehicle
    {
        public int NumberOFWheels { get; set; }
        public string Type { get; set; }
        public virtual void Repair()
        {
            Console.WriteLine("The Vehicle was successfully reapird");
            
        }

    }
}
