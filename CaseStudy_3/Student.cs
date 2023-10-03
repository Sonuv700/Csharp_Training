using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_3
{
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
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enroll> enrollments = new List<Enroll>();

        public void Introduce(Course course)
        {
            courses.Add(course);
        }

        public void Register(Student student)
        {
            students.Add(student);
        }

        public List<Student> ListOfStudents()
        {
            return students;
        }

        public List<Course> ListOfCourses()
        {
            return courses;
        }

        public void Enroll(Student student, Course course)
        {
            DateTime enrollmentDate = DateTime.Now;
            enrollments.Add(new Enroll(student, course, enrollmentDate));
        }

        public List<Enroll> ListOfEnrollments()
        {
            return enrollments;
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

    // Define the UserInterface abstract class/interface
    public interface UserInterface
    {
        void ShowFirstScreen();
        void ShowStudentScreen();
        void ShowAdminScreen();
        void ShowAllStudentsScreen();
        void ShowStudentRegistrationScreen();
        void IntroduceNewCourseScreen();
        void ShowAllCoursesScreen();
    }

    // Implement the UserInterface with a basic implementation
    public class ConsoleUserInterface : UserInterface
    {
        private AppEngine engine;
        private Info info;

        public ConsoleUserInterface(AppEngine engine, Info info)
        {
            this.engine = engine;
            this.info = info;
        }

        public void ShowFirstScreen()
        {
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
            Console.WriteLine("Enter your choice (1 or 2): ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
                default:
                    Console.WriteLine("Invalid Op. Please Select 1 or 2");
                    ShowFirstScreen();
                    break;

            }
        }

        public void ShowStudentScreen()
        {
            // Implement student screen
            Console.WriteLine("Student screen placeholder");
        }

        public void ShowAdminScreen()
        {
            // Implement admin screen
            Console.WriteLine("Admin screen placeholder.");
        }

        public void ShowAllStudentsScreen()
        {
            // Implement showing all students
            Console.WriteLine("All Student screen placeholder.");
        }

        public void ShowStudentRegistrationScreen()
        {
            // Implement student registration
            Console.WriteLine("Student registration screen placeholder.");
        }

        public void IntroduceNewCourseScreen()
        {
            // Implement introducing a new course
            Console.WriteLine("introducing a new course screen placeholder.");
        }

        public void ShowAllCoursesScreen()
        {
            // Implement showing all courses
            Console.WriteLine("All courses screen placeholder.");
            Console.ReadLine();
        }
    }

    // Main application class
    class App
    {
        static void Main(string[] args)
        {
            AppEngine engine = new AppEngine();
            Info info = new Info();
            UserInterface userInterface = new ConsoleUserInterface(engine, info);

            userInterface.ShowFirstScreen();
            Console.ReadLine();
        }
       
    }

}
