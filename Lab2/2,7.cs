using System;

class Counter
{
    public int count;

    // Constructor to initialize the count
    public Counter(int initialCount)
    {
        count = initialCount;
    }

    // Overloading the unary -- (decrement) operator
    public static Counter operator --(Counter obj)
    {
        obj.count--;  // Decrement the value of count by 1
        return obj;
    }

    // Overloading the unary ! (logical NOT) operator
    public static bool operator !(Counter obj)
    {
        // Returns true if count is zero, false otherwise
        return obj.count == 0;
    }

    // Method to display the current count
    public void Display()
    {
        Console.WriteLine($"Count: {count}");
    }
    /*

    static void Main(string[] args)
    {
        // Creating an object with an initial count of 5
        Counter counter1 = new Counter(5);

        Console.WriteLine("Original Count:");
        counter1.Display();

        // Applying unary -- operator (decrement)
        --counter1;  // Decreases the count by 1
        Console.WriteLine("\nAfter applying -- operator:");
        counter1.Display();

        // Applying unary ! operator (logical NOT)
        bool isZero = !counter1;  // Check if count is zero
        Console.WriteLine($"\nIs the count zero? {isZero}");

        // Decrease the count to zero manually for testing the ! operator
        counter1 = new Counter(0);
        isZero = !counter1;  // Check again if count is zero
        Console.WriteLine($"\nAfter setting count to zero, is the count zero? {isZero}");
        Console.ReadKey();
    } */
}
