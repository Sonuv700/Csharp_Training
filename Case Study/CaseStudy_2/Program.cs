using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeBase_2
{
    using System;
    using System.Collections.Generic;

    // Define the Student class with id, name, and dateofbirth properties
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    // Define the Course class with course code and course name properties
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
    }

    // Define the Enroll class with student, course, and enrollmentDate properties
    public class Enroll
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            Student = student;
            Course = course;
            EnrollmentDate = enrollmentDate;
        }
    }

    // Define the AppEngine class with methods for managing students, courses, and enrollments
    public class AppEngine
    {
        public List<Student> students = new List<Student>();
        public List<Course> courses = new List<Course>();
        public List<Enroll> enrollments = new List<Enroll>();

        public void Introduce(Course course)
        {
            courses.Add(course);
        }

        public void Register(Student student)
        {
            students.Add(student);
        }

        public Student[] ListOfStudents()
        {
            return students.ToArray();
        }

        public Course[] ListOfCourses()
        {
            return courses.ToArray();
        }

        public void Enroll(Student student, Course course)
        {
            DateTime enrollmentDate = DateTime.Now;
            enrollments.Add(new Enroll(student, course, enrollmentDate));
        }

        public Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }
    }

    // Define the Info class with a method to display enrollment details
    public class Info
    {
        public void DisplayEnrollment(Enroll enrollment)
        {
            Console.WriteLine("Enrollment Details:");
            Console.WriteLine($"Student: {enrollment.Student.Name}");
            Console.WriteLine($"Course: {enrollment.Course.CourseName}");
            Console.WriteLine($"Enrollment Date: {enrollment.EnrollmentDate}");
            Console.WriteLine();
        }
    }

    // Main application class
    class App
    {
        static void Main(string[] args)
        {
            AppEngine engine = new AppEngine();
            Info info = new Info();

            // Test the AppEngine methods
            engine.Introduce(new Course { CourseCode = "CS101", CourseName = "Computer Science 1900" });
            engine.Register(new Student { Id = 10, Name = "Sonu Verma", DateOfBirth = new DateTime(2002, 07, 01) });

            // Enroll a student in a course
            Student student = engine.ListOfStudents()[0];
            Course course = engine.ListOfCourses()[0];
            engine.Enroll(student, course);

            // Display enrollment details
            Enroll[] enrollments = engine.ListOfEnrollments();
            foreach (Enroll enrollment in enrollments)
            {
                info.DisplayEnrollment(enrollment);
            }
            Console.ReadLine();
        }
    }
}