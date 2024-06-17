using System;

namespace OOPDemo
{
    // Base class
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            genericAnimal.MakeSound(); // Output: Some generic sound
            dog.MakeSound();           // Output: Bark
            cat.MakeSound();           // Output: Meow

            Console.ReadLine(); // Wait for user input before closing the console window
        }
    }
}