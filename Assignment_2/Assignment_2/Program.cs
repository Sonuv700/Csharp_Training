using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Assignment_2
    {
        static void Main(string[] args)
        {
            Solution_2_A();
            Console.WriteLine();
            Solution_2_B();

            Console.ReadLine();
        }
        static void Solution_2_A()
        {
            Console.WriteLine(".................Solution of 2_A...............");
            Console.WriteLine("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n]; //input value in array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the elements of array {i + 1} :");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Calculate Average Value Of Array
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double average = sum / n;

            // Minimum and Maximum value in an array

            int min = numbers[0];
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }

            //Print Result

            Console.WriteLine("Array elements : " + string.Join(", ", numbers));
            Console.WriteLine("Average value : " + average);
            Console.WriteLine("Minimum Value : " + min);
            Console.WriteLine("Maximum Value : " + max);
        }

        static void Solution_2_B()
        {
            Console.WriteLine(".................Solution of 2_A...............");

            int i = 0;
            int[] marks = new int[10];
            Console.WriteLine("Enter Ten Marks : ");
            for (i = 0; i < 10; i++)
            {
                Console.Write($"Enter the  Marks {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());

            }

            // Finding Total Marks
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            Console.WriteLine("Total Marks : " + total);

            // Finding Average Marks
            double average = total / 10;
            Console.WriteLine("Average Marks : " + average);


            // Finding Minimum Marks
            int min = marks[0];
            for (i = 1; i < 10; i++)
            {
                if (min > marks[i])
                    min = marks[i];
            }
            Console.WriteLine("Minimum Marks is :" + min);

            // Finding Maximum Marks
            int max = marks[0];
            for (i = 1; i < 10; i++)
            {
                if (max < marks[i])
                    max = marks[i];
            }
            Console.WriteLine("Maximum Marks is :" + max);


            // Sorting Marks in Ascending Order
            Array.Sort(marks);
            Console.WriteLine("Marks in Ascending Order");
            foreach (int mark in marks)
            {
                Console.Write(mark + " ");

            }
            Console.WriteLine();

            // Sorting Marks in Descending Order

            Array.Reverse(marks);
            Console.WriteLine("Marks in descending order:");

            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();


        }
    }
}