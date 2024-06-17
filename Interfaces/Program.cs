using System;

namespace OOPDemo
{
    // Interface definition
    public interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();       // Output: Car is moving
            bicycle.Move();   // Output: Bicycle is moving

            Console.ReadLine(); // Wait for user input before closing the console window
        }
    }
}