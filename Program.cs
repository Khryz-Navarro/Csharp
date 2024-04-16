using System;

namespace Calculator_Project
{
    internal class Program
    {
        private static int add(int a, int b)
        {
            return a + b;
        }
        private static int subtract(int a, int b)
        {
            return a - b;
        }
        private static int multiply(int a, int b)
        {
            return a * b;
        }
        private static int divide(int a, int b)
        {
            return a / b;
        }
        private static int modulus(int a, int b)
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            int num1, num2, choice;


            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select Operator \n1.Addition \n2.Subtraction \n3.Multiplication \n4.Division \n5.Modulus \nOperator: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Result: " + add(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Result: " + subtract(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Result: " + multiply(num1, num2));
                    break;
                case 4:
                    if(num2 != 0)
                    {
                        Console.WriteLine("Result: " + divide(num1, num2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot Divide By Zero");
                    }
                    break;
                case 5:
                    Console.WriteLine("Result: " + modulus(num1, num2));
                    break;
                default:
                    Console.WriteLine("\nInvalid Operation!");
                    break;
            }

            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
