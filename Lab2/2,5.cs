//Write a C# program to create virtual method in C#.

using System;

namespace VirtualMethodExample
{
    // Base class
    class Animal
    {
        // Virtual method
        public virtual void Sound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // Derived class - Dog
    class Dog : Animal
    {
        // Override virtual method
        public override void Sound()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    // Derived class - Cat
    class Cat : Animal
    {
        // Override virtual method
        public override void Sound()
        {
            Console.WriteLine("The cat meows.");
        }
    }

    class Program
    {
        /*
        static void Main(string[] args)
        {
            
            // Base class reference to derived class objects
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // Calls overridden methods
            myDog.Sound(); // Output: The dog barks.
            myCat.Sound(); // Output: The cat meows.

            // Calling base class method
            Animal genericAnimal = new Animal();
            genericAnimal.Sound(); // Output: The animal makes a sound.
            Console.ReadKey();
        }  */
    }
}
