using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int result;
            Console.WriteLine("enter a number");
            x = Convert.ToInt32(Console.ReadLine());
            result = x * 1;
            Console.WriteLine("the table is :{0}X{1}={2}", x, 1, result);
            result = x * 2;
            Console.WriteLine("the table is :{0}X{1}={2}", x, 2, result);
            result = x * 3;
            Console.WriteLine("the table is :{0}X{1}={2}", x, 3, result);
            result = x * 4;
            Console.WriteLine("the table is :{0}X{1}={2}", x, 4, result);
            result = x * 5;
            Console.WriteLine("the table is :{0}X{1}={2}", x, 5, result);
            result = x * 6;
            Console.WriteLine("the table is :{0}X{1}={2}", x, 6, result);
            result = x * 7;
            Console.WriteLine("the table is :{0}X{1}={2}", x, 7, result);
            result = x * 8;
            Console.WriteLine("the table is :{0}X{1}={2}", x, 8, result);
            result = x * 9;
            Console.WriteLine("the table is :{0}X{1}={2}", x, 9, result);
            result = x * 10;
            Console.WriteLine("the table is :{0}X{1}={2}", x, 10, result);
            Console.ReadLine();

            //////////
            /////////
            /////////

            Console.WriteLine(test("Python", 1));
            Console.WriteLine(test("Python", 0));
            Console.WriteLine(test("Python", 4));
            Console.ReadLine();

        }
        public static string test(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
   
}
