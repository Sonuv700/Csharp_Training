using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Triangle : IShapes
    {
        double b;
        double h;
        double side1;
        double side2;
        double side3;
        public Triangle()
        {
            // Constructor to get input from the user for Base and Height
            Console.WriteLine("Enter the Base of Triangle");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Height Of Triangle");
            h = double.Parse(Console.ReadLine());
            // Taking All Side input for Circumfernce
            Console.WriteLine("Enter the First side of Triangle");
            side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second side of Triangle");
            side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third side of Triangle");
            side3 = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return (b * h) / 2;
        }

        public double GetCircumference()
        {
            return side1 + side2 + side3;
        }
    }
}