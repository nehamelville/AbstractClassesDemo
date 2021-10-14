using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }
        
        public string Year { get; set; } 
        public string Make { get; set; } 
        public string Model { get; set; }

        
        public abstract void  DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("You are driving a vehicle!!\n");
        }        

    }
}

