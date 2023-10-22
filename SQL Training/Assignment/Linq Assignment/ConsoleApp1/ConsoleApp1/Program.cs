using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment_linq
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>
            {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 8, 6), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 12, 4), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 3, 6), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 8, 3), DOJ =new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 1, 6), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 6, 11), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 12, 8), DOJ = new DateTime(2014, 3, 12), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 12, 4), DOJ = new DateTime(2016, 2, 1), City = "Pune" },
        };
            // Task 1: Display employees who joined before 1/1/2015



            var joinedBefore2015 = empList.Where(e => e.DOJ < new DateTime(2015, 1, 1));



            Console.WriteLine("Employees who joined before 1/1/2015:");



            foreach (var employee in joinedBefore2015)



            {



                Console.WriteLine($"{employee.EmployeeID}: {employee.FirstName} {employee.LastName}");



            }





            // Task 2: Display employees born after 1/1/1990



            var bornAfter1990 = empList.Where(e => e.DOB > new DateTime(1990, 1, 1));



            Console.WriteLine("Employees born after 1/1/1990:");



            foreach (var employee in bornAfter1990)



            {



                Console.WriteLine($"{employee.EmployeeID}: {employee.FirstName} {employee.LastName}");



            }





            // Task 3: Display consultants and associates



            var consultantsAndAssociates = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");



            Console.WriteLine("Consultants and Associates:");



            foreach (var employee in consultantsAndAssociates)



            {



                Console.WriteLine($"{employee.EmployeeID}: {employee.FirstName} {employee.LastName}");



            }





            // Task 4: Total number of employees



            int totalEmployees = empList.Count;



            Console.WriteLine($"Total number of employees: {totalEmployees}");





            // Task 5: Total number of employees in Chennai



            int chennaiEmployees = empList.Count(e => e.City == "Chennai");



            Console.WriteLine($"Total number of employees in Chennai: {chennaiEmployees}");





            // Task 6: Highest employee ID



            int highestEmployeeID = empList.Max(e => e.EmployeeID);



            Console.WriteLine($"Highest Employee ID: {highestEmployeeID}");





            // Task 7: Employees joined after 1/1/2015



            int employeesJoinedAfter2015 = empList.Count(e => e.DOJ > new DateTime(2015, 1, 1));



            Console.WriteLine($"Employees joined after 1/1/2015: {employeesJoinedAfter2015}");





            // Task 8: Employees with titles not "Associate"



            int employeesNotAssociate = empList.Count(e => e.Title != "Associate");



            Console.WriteLine($"Employees with titles not 'Associate': {employeesNotAssociate}");





            // Task 9: Total number of employees based on city



            var employeesByCity = empList.GroupBy(e => e.City).Select(g => new { City = g.Key, Count = g.Count() });



            Console.WriteLine("Total number of employees based on City:");



            foreach (var cityGroup in employeesByCity)



            {



                Console.WriteLine($"{cityGroup.City}: {cityGroup.Count}");



            }





            // Task 10: Total number of employees based on city and title



            var employeesByCityAndTitle = empList.GroupBy(e => new { e.City, e.Title }).Select(g => new { City = g.Key.City, Title = g.Key.Title, Count = g.Count() });



            Console.WriteLine("Total number of employees based on City and Title:");



            foreach (var group in employeesByCityAndTitle)



            {



                Console.WriteLine($"{group.City}, {group.Title}: {group.Count}");



            }





            // Task 11: Youngest employee



            var youngestEmployee = empList.OrderBy(e => e.DOB).First();



            Console.WriteLine($"Youngest employee: {youngestEmployee.FirstName} {youngestEmployee.LastName}");
            Console.ReadLine();




        }



    }
}
