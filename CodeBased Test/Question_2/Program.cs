using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorApp
{
    // Define a delegate for the calculator operations
    delegate int CalculatorOperation(int a, int b);

    class Question_2
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculator Menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Quit");

                Console.Write("Enter your choice (/2/3/4/5): ");
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice == 5)
                    {
                        break;
                    }
                    else if (choice >= 1 && choice <= 4)
                    {
                        Console.Write("Enter the first number: ");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter the second number: ");
                        int num2 = int.Parse(Console.ReadLine());

                        CalculatorOperation calculatorOperation;

                        // Assign the appropriate calculator operation based on user choice
                        switch (choice)
                        {
                            case 1:
                                calculatorOperation = Add;
                                break;
                            case 2:
                                calculatorOperation = Subtract;
                                break;
                            case 3:
                                calculatorOperation = Multiply;
                                break;
                            case 4:
                                calculatorOperation = Divide;
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                continue;
                        }

                        // Perform the calculation and display the result
                        int result = calculatorOperation(num1, num2);
                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.WriteLine();
            }
        }

        // Methods for calculator operations
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
            return a / b;
        }
    }
}
