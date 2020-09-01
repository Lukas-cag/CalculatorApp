using Microsoft.Win32.SafeHandles;
using System;

namespace CalculatorApp
{


    class Program
    {

        static void Main(string[] args)
        {
            string num1;
            string num2;

            string operation;

            Console.WriteLine("Welcome to Calculator app\nPlease enter the first number\n>>> ");
            num1 = Console.ReadLine();

            Console.WriteLine("Please enter the second number\n>>> ");
            num2 = Console.ReadLine();

            Console.WriteLine("Finally, what operation would you like performed?\n>>> ");
            operation = Console.ReadLine();

            int num1int = Int32.Parse(num1);
            int num2int = Int32.Parse(num1);

            while (true)
            {
                if (operation.ToLower() == "add" || operation.ToLower() == "addition")
                {
                    Console.WriteLine(num1int + num2int);
                    break;

                }
                else if (operation.ToLower() == "subtract" || operation.ToLower() == "subtraction")
                {
                    Console.WriteLine(num1int - num2int);
                    break;
                }
                else if (operation.ToLower() == "multiply" || operation.ToLower() == "multiplication")
                {
                    Console.WriteLine(num1int * num2int);
                    break;
                }
                else if (operation.ToLower() == "divide" || operation.ToLower() == "division")
                {
                    Console.WriteLine(num1int / num2int);
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect command try:\ndivide\nmultiply\nsubtract\nadd");
                    break;
                }
            }


            




        }
    }
}
