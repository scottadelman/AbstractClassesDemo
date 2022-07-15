using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 0;
        public string Make { get; set; } = "Manufacturer";
        public string Model { get; set; } = "Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I am driving!");
        }
    }
}
