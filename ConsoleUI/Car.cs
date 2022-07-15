using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public int NumberOfCylinders { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("I'm driving a car!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Cars aren't as fun as motorcycles :(");
        }
    }
}
