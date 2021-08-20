using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool HasSideCart;
        public override int Year { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The MOTORCYCLE is in Drive Abstractly.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("The MOTORCYCLE is in Drive Virtually.");
        }
    }
}
