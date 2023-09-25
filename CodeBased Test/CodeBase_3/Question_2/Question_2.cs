using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Box
    {
       // Members
    public double Length { get; set; }
        public double Breadth { get; set; }

        // Constructor
        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        // Function to add two Box instance and store the result in a third Box
        public static Box AddBoxes(Box box1, Box box2)
        {
            double newLength = box1.Length + box2.Length;
            double newBreadth = box1.Breadth + box2.Breadth;
            return new Box(newLength, newBreadth);
        }

        // Display the details of the Box
        public void DisplayDetails()
        {
            Console.WriteLine($"Length: {Length} units");
            Console.WriteLine($"Breadth: {Breadth} units");
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            // Create two Box Instance
            Box box1 = new Box(19.99, 12.0);
            Box box2 = new Box(67.5, 91.5);

            // Add the two Box instance and store the result in a third Box
            Box box3 = Box.AddBoxes(box1, box2);

            // Display the details of the third Box
            Console.WriteLine("Details of the Third Box:");
            Console.Write("_________________________\n");
            box3.DisplayDetails();
            Console.ReadLine();
        }
    }
}
