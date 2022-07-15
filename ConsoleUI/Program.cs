using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            
            Car car1 = new Car() { Year = 2009, Make = "Subaru", Model = "Forester", NumberOfCylinders = 4 };
            Vehicle car2 = new Car() { Year = 2020, Make = "Toyota", Model = "Tundra", NumberOfCylinders = 6 };
            Motorcycle bike1 = new Motorcycle() { Year = 2017, Make = "Yamaha", Model = "FZ-09", SizeOfMotor = 900 };
            Vehicle bike2 = new Motorcycle() { Year = 2015, Make = "Yamaha", Model = "Bolt R-Spec", SizeOfMotor = 950 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(bike1);
            vehicles.Add(bike2);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model} \n");
            }

            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine("\n \n \n \n \n \n \n");
            car1.DriveAbstract();
            Console.WriteLine();

            car1.DriveVirtual();
            Console.WriteLine();

            bike1.DriveAbstract();
            Console.WriteLine();

            bike1.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}