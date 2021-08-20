using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }
        
        public bool HasTrunk;
        public override int Year { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override void DriveAbstract()

        {
            Console.WriteLine("The CAR is in Drive Abstractly.");
        }
    }
}
