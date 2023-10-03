using System;


// Define the Student class with properties (id, name, dateofbirth)
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    // Constructor to initialize the properties
    public Student(int id, string name, DateTime dateOfBirth)
    {
        Id = id;
        Name = name;
        DateOfBirth = dateOfBirth;
    }
}

// Define the Info class with a method to display student details
public class Info
{
    public void Display(Student student)
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine($"ID: {student.Id}");
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Date of Birth: {student.DateOfBirth.ToShortDateString()}");
    }
}

// Main application class
class App
{
    static void Main(string[] args)
    {
        Info info = new Info();

        Console.WriteLine("Scenario 1: Create and display student objects");

        // Prompt for the number of students to input (Scenario 1)
        Console.Write("Enter the number of students for Scenario 1: ");
        int numberOfStudents1 = Convert.ToInt32(Console.ReadLine());

        // Create student objects with user input (Scenario 1)
        for (int i = 1; i <= numberOfStudents1; i++)
        {
            Console.WriteLine($"Enter Details for Student {i} (Scenario 1)");
            Student student = CreateStudentWithInput();
            info.Display(student);
            Console.WriteLine(); // Add a line break for separation
        }

        Console.WriteLine("\nScenario 2: Create an array of students and display their details");

        // Prompt for the number of students to input (Scenario 2)
        Console.Write("Enter the number of students for Scenario 2: ");
        int numberOfStudents2 = Convert.ToInt32(Console.ReadLine());

        // Create an array of students and store objects in it (Scenario 2)
        Student[] studentsArray = new Student[numberOfStudents2];
        for (int i = 0; i < numberOfStudents2; i++)
        {
            Console.WriteLine($"Enter Details for Student {i + 1} (Scenario 2)");
            studentsArray[i] = CreateStudentWithInput();
        }

        // Iterate over the array and display student details (Scenario 2)
        foreach (Student student in studentsArray)
        {
            info.Display(student);
            Console.WriteLine(); // Add a line break for separation
        }
    }

    // Helper method to create a student with user input
    static Student CreateStudentWithInput()
    {
        Console.Write("Enter Student ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Date of Birth (yyyy-MM-dd): ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

        return new Student(id, name, dateOfBirth);
    }
}