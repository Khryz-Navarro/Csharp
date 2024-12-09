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
            int loops;

            do
            {
                Console.Write("Enter First Number: ");
                while (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter First Number: ");
                }

                Console.Write("Enter Second Number: ");
                while (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter Second Number: ");
                }

                Console.Write("Select Operator \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Division \n5. Modulus \nOperator: ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                    Console.Write("Select Operator: ");
                }

                switch (choice)
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
                        if (num2 != 0)
                        {
                            Console.WriteLine("Result: " + divide(num1, num2));
                        }
                        else
                        {
                            Console.WriteLine("Cannot Divide By Zero");
                        }
                        break;
                    case 5:
                        if (num2 != 0)
                        {
                            Console.WriteLine("Result: " + modulus(num1, num2));
                        }
                        else
                        {
                            Console.WriteLine("Cannot Perform Modulus By Zero");
                        }
                        break;
                    default:
                        Console.WriteLine("\nInvalid Operation!");
                        break;
                }

                Console.Write("Do you want to continue? \n1. YES \n2. NO \nChoice: ");
                while (!int.TryParse(Console.ReadLine(), out loops) || (loops != 1 && loops != 2))
                {
                    Console.WriteLine("Invalid input. Please enter 1 for YES or 2 for NO.");
                }

            } while (loops == 1);

            Console.WriteLine("Press Enter to Exit");
            Console.ReadKey();
        }
    }
}
