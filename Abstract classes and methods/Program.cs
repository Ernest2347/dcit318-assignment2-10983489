using System;

namespace OOPDemo
{
    // Abstract class
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(2.0, 4.0);

            Console.WriteLine($"Area of the circle: {circle.GetArea()}");        // Output: Area of the circle: 78.53981633974483
            Console.WriteLine($"Area of the rectangle: {rectangle.GetArea()}");  // Output: Area of the rectangle: 24.0

            Console.ReadLine(); // Wait for user input before closing the console window
        }
    }
}