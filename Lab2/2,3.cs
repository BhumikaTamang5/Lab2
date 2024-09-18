//Write a C# program to demonstrate partial class.

using System;

namespace PartialClassDemo
{
    // First part of the partial class
    public partial class MyClass
    {
        private string Author_name;
        private int Total_articles;

        // Constructor to initialize fields
        public MyClass(string a, int t)
        {
            this.Author_name = a;
            this.Total_articles = t;
        }
    }

    // Second part of the partial class
    public partial class MyClass
    {
        // Method to display the fields
        public void Display()
        {
            Console.WriteLine("Author's name is: " + Author_name);
            Console.WriteLine("Total number of articles is: " + Total_articles);
        }
    }

    // Main program class to test partial class
    class Program
    {
        /*
        static void Main(string[] args)
        {
            // Creating an instance of the partial class
            MyClass author = new MyClass("Bhumika", 25);

            // Calling the display method
            author.Display();

            // Keeping the console window open
            Console.ReadLine();
        } */
    }
}
