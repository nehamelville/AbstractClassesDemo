using System;
namespace ConsoleUI
{
    public class Motorcycle:Vehicle
    {
        public Motorcycle()
        {
        }
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("You are riding a Motorcycle!!\n");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"You are driving a {GetType().Name}.It is a {GetType().BaseType.Name}!!\n ");
        }

       
    }
}
