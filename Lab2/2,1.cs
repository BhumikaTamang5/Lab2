using System;

namespace Employee1
{
    
    // Employee class definition
    class Employee
    {
        // Fields of the Employee class
        public string Name;
        public string Email;
        public double Salary;

        // Constructor to initialize the Employee object
        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salary: {Salary:C}"); // :C formats the salary as currency
        }
    }

    class Program
    {
        /*
        
        static void Main(string[] args)
        {
            // Creating an instance (object) of the Employee class
            Employee emp1 = new Employee("Bhumika", "bhumika@example.com", 56000.00);

            // Displaying the employee details
            emp1.DisplayEmployeeDetails();

            // Waiting for user input before closing the console window
            Console.ReadLine();
        } */
}
    }
