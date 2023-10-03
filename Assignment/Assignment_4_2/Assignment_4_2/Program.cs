using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_2
{
    class Student
    {
        private string Rollno;
        private string Name;
        private string Branch;
        private string Section;
        private string Semester;

        private int[] marks = new int[5];

        public Student(string rollno, string name, string Branch, string Section, string semester)
        {
            this.Rollno = rollno;
            this.Name = name;
            this.Branch = Branch;
            this.Section = Section;
            this.Semester = semester;
        }
        public void GetScore()
        {
            Console.WriteLine("Enter marks of an 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Subject marks {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }



        public void DisplayResult()
        {
            if (Array.Exists(marks, mark => mark < 35))
            {
                Console.WriteLine("Failed");
                Console.ReadLine();
            }
            else if (CalculateAverage() < 50)
            {
                Console.WriteLine("Failed");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Passed");
                Console.ReadLine();
            }
        }
        public void DisplayData()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Roll No: {Rollno}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Branch: {Branch}");
            Console.WriteLine($"Section: {Section}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine("Marks in 5 subjects:");
            Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
                Console.ReadLine();
            }
        }
        private double CalculateAverage()
        {
            return marks.Sum() / 5.0;
        }
        public static void Main(string[] args)
        {
            Student student1 = new Student("190056", "SONU ","IT" ,"A", "7st");
            student1.GetScore();
            student1.DisplayResult();
            student1.DisplayData();
        }
    }
}
