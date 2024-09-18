using System;

namespace InheritanceDemo
{
    // Base class (Person)
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // 1. Single Inheritance
    // Student inherits from Person
    public class Student : Person
    {
        public int StudentID { get; set; }

        public void DisplayStudentDetails()
        {
            DisplayPersonDetails();
            Console.WriteLine($"Student ID: {StudentID}");
        }
    }

    // 2. Multilevel Inheritance
    // GraduateStudent inherits from Student
    public class GraduateStudent : Student
    {
        public string Degree { get; set; }

        public void DisplayGraduateStudentDetails()
        {
            DisplayStudentDetails();
            Console.WriteLine($"Degree: {Degree}");
        }
    }

    // 3. Hierarchical Inheritance
    // Teacher also inherits from Person
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public void DisplayTeacherDetails()
        {
            DisplayPersonDetails();
            Console.WriteLine($"Subject: {Subject}");
        }
    }

    // 4. Multiple Inheritance using Interfaces
    public interface IWriter
    {
        void WriteArticle();
    }

    public class Researcher : Person, IWriter
    {
        public void WriteArticle()
        {
            Console.WriteLine($"{Name} is writing an article.");
        }
    }

    // Main program
    class Program
    {
        /*
        static void Main(string[] args)
        {
            // 1. Single Inheritance
            Student student = new Student() { Name = "Bhumika", Age = 21, StudentID = 1 };
            student.DisplayStudentDetails();
            Console.WriteLine();

            // 2. Multilevel Inheritance
            GraduateStudent gradStudent = new GraduateStudent() { Name = "Divya", Age = 21, StudentID = 2, Degree = "BCA" };
            gradStudent.DisplayGraduateStudentDetails();
            Console.WriteLine();

            // 3. Hierarchical Inheritance
            Teacher teacher = new Teacher() { Name = "Rojina", Age = 21, Subject = "Mathematics" };
            teacher.DisplayTeacherDetails();
            Console.WriteLine();

            // 4. Multiple Inheritance using Interfaces
            Researcher researcher = new Researcher() { Name = "Raya", Age = 22 };
            researcher.DisplayPersonDetails();
            researcher.WriteArticle();

            Console.ReadLine(); // Keeps the console window open
        } */
    }
}
