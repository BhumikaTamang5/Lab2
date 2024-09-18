//9) Write a program to demonstrate different types of property in C#.

using System;

class Person
{
    // Private fields
    private string name;
    private int age;

    // 1. Read-Write Property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // 2. Read-Only Property
    public int Age
    {
        get { return age; }
    }

    // 3. Write-Only Property
    private string password;
    public string Password
    {
        set { password = value; }
    }

    // 4. Auto-Implemented Property (Compiler automatically creates the backing field)
    public string Address { get; set; }

    // 5. Computed Property (Calculates full name based on first and last name)
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get { return FirstName + " " + LastName; }
    }

    // Constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

class Program
{
    
    static void Main(string[] args)
    {
        // Creating a new person object
        Person person = new Person("Bhumika Tamang", 20);

        // 1. Using Read-Write property
        Console.WriteLine("Name: " + person.Name);
        person.Name = "Bhumika";  // Changing the name
        Console.WriteLine("Updated Name: " + person.Name);

        // 2. Using Read-Only property
        Console.WriteLine("Age: " + person.Age);

        // 3. Using Write-Only property (You can only set it, not read it)
        person.Password = "bhumika123"; // Setting the password

        // 4. Using Auto-Implemented Property
        person.Address = "Lalitpur";
        Console.WriteLine("Address: " + person.Address);

        // 5. Using Computed Property
        person.FirstName = "Bhumika";
        person.LastName = "Tamang Theeng";
        Console.WriteLine("Full Name: " + person.FullName);
        Console.ReadLine();
    } */
}
