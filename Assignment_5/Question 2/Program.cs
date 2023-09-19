using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Q2 Create a Program to count the no. of occurrences of a letter in a given string
            //  (for example in a string called “OOPS PROGRAMMING”, O appears 3 times)


            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter the letter to count: ");
            char letterToCount = char.Parse(Console.ReadLine());

            int count = CountLetterOccurrences(inputString, letterToCount);
            int length = inputString.Length;
            Console.WriteLine($"\nNumber of occurrences of '{letterToCount}': {count}");
            Console.WriteLine($"\nThe Lenght of the input string : {length}");
            Console.ReadLine();
        }

        static int CountLetterOccurrences(string inputString, char letter)
        {
            int count = 0;

            foreach (char c in inputString)
            {
                if (char.ToUpper(c) == char.ToUpper(letter))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
