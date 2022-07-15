using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public int SizeOfMotor { get; set; }
               
        public override void DriveAbstract()
        {
            Console.WriteLine("Now I'm riding a motorcycle!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycles are way more fun than cars!");
        }
    }
}
