using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;

namespace ClassLibrary.Models
{
    public class ElectricCar: Car
    {
        public double BatteryCapacity { get; set; }
        public int BatteryPercentage { get; set; }

        public ElectricCar()
        {
            base.EngineType = EngineType.Electric;
        }

        public override void Drive()
        {
            Console.WriteLine($"The max speed of '{Model}' is '{MaxSpeed}");
        }

        public void Recharge()
        {
                Console.WriteLine(BatteryPercentage<20? "The Electric Car needs to be recharged.":$"You have {BatteryPercentage}% battery left");      
        }

        public int WhenOnBattery()
        {
            return MaxSpeed = 80;

        }

    }
}
