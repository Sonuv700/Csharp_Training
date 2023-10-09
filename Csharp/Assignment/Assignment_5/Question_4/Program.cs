using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class Customer
    {
        
        public int CustomerId;
        public string Name;
        public int Age;
        public string Phone;
        public string City;
        public Customer()
        {
            CustomerId = 0;
            Name = "Unknown";
            Age = 0;
            Phone = "N/A";
            City = "N/A";
        }
        public Customer(int customerId, string name, int age, string phone, string city)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }
        public static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine("Customer ID: " + customer.CustomerId);
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("Age: " + customer.Age);
            Console.WriteLine("Phone: " + customer.Phone);
            Console.WriteLine("City: " + customer.City);
        }

        // Destructor
        ~Customer()
        {
            
            Console.WriteLine($"Customer {CustomerId} has been deleted.");
        }
        static void Main()
        {
            
            Customer customer1 = new Customer(1, "Sonu Verma", 21, "7007881150", "Lucknow");

            Console.WriteLine("Customer Information:");
            DisplayCustomer(customer1);

            Customer customer2 = new Customer();

            Console.WriteLine("\nSecond Customer Information:");
            DisplayCustomer(customer2);
            Console.ReadLine();
        }
    }
}