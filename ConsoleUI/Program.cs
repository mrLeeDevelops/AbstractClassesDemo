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
             * DONE--Create an abstract class called Vehicle
             * DONE--The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * DONE--Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE--Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE--Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE--Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE--Provide the implementations for the abstract methods
             * DONE--Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE--Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * DONE-- Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but = use constuctors from derived classes
             * DONE-- - new it up as one of each derived class
             * DONE--Set the properties with object initializer syntax
             */
            var corvette = new Car()
            {
                Year = 2017,
                Make = "Chevy",
                Model = "Corvette"
            };
            var ducati = new Motorcycle()
            {
                Year = 2020,
                Make = "Ducati",
                Model = "Diavel 1260"
            };
            Vehicle van = new Car()
            {
                Year = 2010,
                Make = "Ford",
                Model = "Econoline"
            };
            Vehicle honda= new Motorcycle()
            {
                Year =2019,
                Make = "Honda",
                Model = "RCV1000R"
            };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(corvette);
            vehicles.Add(ducati);
            vehicles.Add(van);
            vehicles.Add(honda);
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Year = {vehicle.Year} Make = {vehicle.Make} Model = {vehicle.Model}");   
            }
            // Call each of the drive methods for one car and one motorcycle
            corvette.DriveAbstract();
            corvette.DriveVirtual();
            ducati.DriveAbstract();
            ducati.DriveVirtual();

            #endregion
            Console.ReadLine();
        }
    }
}
