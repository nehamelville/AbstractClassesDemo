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

            #region 

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


            Car car1 = new Car() {Year="2021",Make= "BMW",Model="X5",HasTrunk=true };
            Motorcycle m1 = new Motorcycle() { Year = "2021", Make = "Ducatti", Model = "Scrambler", HasSideCart = true };
            Vehicle v1 = new Car() { Year = "2021", Make = "Audi", HasTrunk = true, Model = "Q5"};
            Vehicle v2 = new Motorcycle() { Year = "2021", Make = "Harley-Davidson", Model = "IRON 883™",HasSideCart=true };




            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties.
             */

            vehicles.Add(v1);
            vehicles.Add(v2);
            vehicles.Add(car1);
            vehicles.Add(m1);


            foreach (var item in vehicles)
            {
                Console.WriteLine($"\n\nMake: {item.Make}\nModel: {item.Model}\nYear: {item.Year}");

                if (item is Car)
                {
                    Car c = (Car)item;
                    Console.WriteLine("Has trunk: " + (c.HasTrunk?"Yes":"No"));
                }
                else if (item is Motorcycle)
                {
                    Motorcycle m = (Motorcycle)item;
                    Console.WriteLine("Has side cart: " + (m.HasSideCart?"yes":"No"));
                }
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.WriteLine("\n\nCar Abstract Method\n-------------------");
            car1.DriveAbstract();
            Console.WriteLine("Car Virtual Method\n-------------------------");
            car1.DriveVirtual();
            Console.WriteLine("MotorCycle Virtual Method\n---------------------");
            m1.DriveVirtual();
            Console.WriteLine("Motorcycle Abstract Method\n---------------------");
            m1.DriveAbstract();
          
        }
    }
}
