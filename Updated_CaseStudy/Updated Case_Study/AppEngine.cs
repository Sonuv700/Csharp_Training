using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class AppEngine
    {

        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enrollment> enrollments = new List<Enrollment>();

        // Constructor
        public AppEngine()
        {

            InitializeData();
        }
        private void InitializeData()
        {
            

        }

        public void RegisterStudent(Student student)
        {
            students.Add(student);
        }

        public void IntroduceCourse(Course course)
        {
            courses.Add(course);
        }

        public void EnrollStudent(Student student, Course course)
        {
            DateTime enrollmentDate = DateTime.Now;
            enrollments.Add(new Enrollment(student, course, enrollmentDate));
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public List<Course> GetCourses()
        {
            return courses;
        }

        public List<Enrollment> GetEnrollments()
        {
            return enrollments;
        }
    }
}