using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Circle : IShapes
    {
        double r;
        public Circle()
        {
            // Constructor to get input from the user for Radius
            Console.WriteLine("Enter the Radius Of Circle");
            r = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return 3.14 * r * r;
        }

        public double GetCircumference()
        {
            return 2 * 3.14 * r;
        }
    }
}