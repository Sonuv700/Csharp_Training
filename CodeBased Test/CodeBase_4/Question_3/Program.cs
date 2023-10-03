using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Question_3
{
    static void Main()
    {
        // Create a list to store employee records
        List<Employee> empList = new List<Employee>
        {
            new Employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 8, 6), "Mumbai"),
            new Employee(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai"),
            new Employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 12, 4), "Pune"),
            new Employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune"),
            new Employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 3, 8), new DateTime(2016, 2, 2), "Mumbai"),
            new Employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai"),
            new Employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 1, 6), "Mumbai"),
            new Employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 6, 11), "Chennai"),
            new Employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 3, 12), "Chennai"),
            new Employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 2, 1), "Pune")
        };

        // a. Display details of all employees
        Console.WriteLine("a. Details of all employees:");
        foreach (var emp in empList)
        {
            Console.WriteLine(emp);
        }

        // b. Display details of employees whose location is not Mumbai
        Console.WriteLine("\nb. Details of employees not located in Mumbai:");
        var notInMumbai = empList.Where(emp => emp.City != "Mumbai");
        foreach (var emp in notInMumbai)
        {
            Console.WriteLine(emp);
        }

        // c. Display details of employees with the title "AsstManager"
        Console.WriteLine("\nc. Details of employees with the title 'AsstManager':");
        var asstManagers = empList.Where(emp => emp.Title == "AsstManager");
        foreach (var emp in asstManagers)
        {
            Console.WriteLine(emp);
        }

        // d. Display details of employees whose Last Name starts with 'S'
        Console.WriteLine("\nd. Details of employees whose Last Name starts with 'S':");
        var startsWithS = empList.Where(emp => emp.LastName.StartsWith("S"));
        foreach (var emp in startsWithS)
        {
            Console.WriteLine(emp);
        }

        // Add this line to hold the screen until a key is pressed
        Console.ReadKey();
    }
}

class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DOJ { get; set; }
    public string City { get; set; }

    public Employee(int id, string firstName, string lastName, string title, DateTime dob, DateTime doj, string city)
    {
        EmployeeID = id;
        FirstName = firstName;
        LastName = lastName;
        Title = title;
        DOB = dob;
        DOJ = doj;
        City = city;
    }

    public override string ToString()
    {
        return $"Employee ID: {EmployeeID}, Name: {FirstName} {LastName}, Title: {Title}, DOB: {DOB.ToShortDateString()}, DOJ: {DOJ.ToShortDateString()}, City: {City}";
    }
}