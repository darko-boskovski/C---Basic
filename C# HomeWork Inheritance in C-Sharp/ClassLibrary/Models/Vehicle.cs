using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Vehicle
    {
        public Vehicle()
        {

        }

        public Vehicle(int id, string manufacturer, string model)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
        }

        public int Id  { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public void PrintInfo() 
        {

            Console.WriteLine($"id:'{Id}', Manufacturer '{Manufacturer}, Model: '{Model}'");
        
        }

    }
}
