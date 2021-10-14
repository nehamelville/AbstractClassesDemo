using System;
namespace ConsoleUI
{
    public class Car:Vehicle
    {
        public Car()
        {
        }
        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"You are driving a {GetType().Name} and  {(HasTrunk?"has trunk":"has no trunk")}!!\n");
        }

    }
}
