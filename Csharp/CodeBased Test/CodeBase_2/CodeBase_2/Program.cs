//Q 1Create an Abstract class Student with  Name, StudentId, Grade as members
//and also an abstract method Boolean Ispassed(grade) which takes grade as an input
//and checks whether student passed the course or not.  

//Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student
//and overrides Ispassed(grade) methodFor the UnderGrad class, if the grade is above 70.0,
//then isPassed returns true, otherwise it returns false. For the Grad class, if the grade is above
//80.0, then isPassed returns true, otherwise returns false.
//Test the above by creating appropriate objects

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Student
{
    public string Name { get; set; }
    public int StudentId { get; set; }
    public double Grade { get; set; }

    public Student(string name, int studentId, double grade)
    {
        Name = name;
        StudentId = studentId;
        Grade = grade;
    }

    public abstract bool IsPassed(double grade);
}

class UnderGraduate : Student
{
    public UnderGraduate(string name, int studentId, double grade) : base(name, studentId, grade)
    {
    }

    public override bool IsPassed(double grade)
    {
        return grade > 70.0;
    }
}

class Graduate : Student
{
    public Graduate(string name, int studentId, double grade) : base(name, studentId, grade)
    {
    }

    public override bool IsPassed(double grade)
    {
        return grade > 80.0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        UnderGraduate undergradStudent = new UnderGraduate("Sonu Verma", 103381, 75.0);
        Graduate gradStudent = new Graduate("Aman Verma", 190056, 79.999);

        Console.WriteLine("Undergraduate Student:");
        Console.WriteLine("______________________");
        Console.WriteLine("Name: " + undergradStudent.Name);
        Console.WriteLine("Student ID: " + undergradStudent.StudentId);
        Console.WriteLine("Grade: " + undergradStudent.Grade);
        Console.WriteLine("Passed: " + undergradStudent.IsPassed(undergradStudent.Grade));

        Console.WriteLine("\n\nGraduate Student:");
        Console.WriteLine("_________________");
        Console.WriteLine("Name: " + gradStudent.Name);
        Console.WriteLine("Student ID: " + gradStudent.StudentId);
        Console.WriteLine("Grade: " + gradStudent.Grade);
        Console.WriteLine("Passed: " + gradStudent.IsPassed(gradStudent.Grade));
        Console.ReadLine();
    }
}