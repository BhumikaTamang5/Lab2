//6) Write a C# program to demonstrate different types of constructor.


using System;

class Sample
{
    public int number;
    public string text;

    // 1. Default Constructor (also an instance constructor)
    public Sample()
    {
        number = 0;
        text = "Default Constructor";
        Console.WriteLine("Default Constructor called");
    }

    // 2. Instance Constructor (Parameterized Constructor)
    public Sample(int num, string txt)
    {
        number = num;
        text = txt;
        Console.WriteLine("Instance Constructor (Parameterized) called");
    }

    // 3. Overloaded Constructor (Different parameter list)
    public Sample(int num)
    {
        number = num;
        text = "Overloaded Constructor";
        Console.WriteLine("Overloaded Constructor called");
    }

    // 4. Static Constructor
    static Sample()
    {
        Console.WriteLine("Static Constructor called (This is called only once)");
    }

    // Method to display object details
    public void Display()
    {
        Console.WriteLine($"Number: {number}, Text: {text}");
    }
    
    /*
    static void Main(string[] args)
    {
        // Static constructor will be called only once when the class is first used.

        // Using Default Constructor
        Sample obj1 = new Sample();
        obj1.Display();

        // Using Instance Constructor (Parameterized)
        Sample obj2 = new Sample(42, "Instance Constructor Example");
        obj2.Display();

        // Using Overloaded Constructor
        Sample obj3 = new Sample(100);
        obj3.Display();

        Console.ReadKey();
    } */
}
