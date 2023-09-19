using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution_3_A();
            Console.WriteLine();
            Solution_3_B();
            Console.WriteLine();
            Solution_3_C();
            Console.Read();

        }
        static void Solution_3_A()
        {
            Console.WriteLine("...............Solution_3_A...............");
            Console.WriteLine("Enter a Word ");
            string input = Console.ReadLine();
            Console.WriteLine($"The Length of word is {input.Length}");
        }

        static void Solution_3_B()
        {
            Console.WriteLine("...............Solution_3_B...............");
            Console.WriteLine("Enter a Word ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedword = new string(charArray);

            Console.WriteLine("Reversed word is : " + reversedword);

        }
        static void Solution_3_C()
        {

            Console.WriteLine("...............Solution_3_C...............");
            Console.WriteLine("Enter the First Word : ");
            string word_1 = Console.ReadLine();
            Console.WriteLine("Enter the Second Word : ");
            string word_2 = Console.ReadLine();
            if (word_1 == word_2)
            {
                Console.WriteLine($"First Word {word_1} and Second Word {word_2} are Same.");
            }
            else
            {
                Console.WriteLine($"First Word {word_1} and Second Word {word_2} are Not Same.");
            }


        }
    }
}