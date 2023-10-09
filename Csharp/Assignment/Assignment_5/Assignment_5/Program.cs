//Q1   Create a Class Program which would be used to accepts two  Strings -
//     FirstName and LastName and call the static method Display() that displays the first name
//     in one line and the LastName in the second line after converting the same to upper case.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
     class Program
    {
        static void Main(string[] args)
        {
            //string str;
            //Console.Write(" Accept a string from Keyboard:\n");
            //Console.Write("\n---------------------------------\n");
            //Console.Write("Input the string:");
            //str = Console.ReadLine();
            //Console.Write("The String you Entered is:{0}\n", str);
            //Console.Write("The String you Entered is:{0}\n", str.Length);
            //Console.ReadLine();



            Console.Write("Enter the First Name\n");
            string FirstName = Console.ReadLine();

            Console.Write("\nEnter the Last Name\n");
            string LastName = Console.ReadLine();

            Console.Write("\n-------------------\n");
            Display(FirstName, LastName);

        }
        public static void Display(string FirstName, string LastName)
        {
            string FullName = $"{FirstName} {LastName}";
            Console.WriteLine($"FirstName:{FirstName.ToUpper()}\n");
            Console.WriteLine($"LastName:{LastName.ToUpper()}\n");
            Console.WriteLine($"FullName:{FullName.ToUpper()}");
            Console.ReadLine();

        }

    }
}
