using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt2
{
    internal class SecondAssignment3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation: \n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            int choice = int.Parse(Console.ReadLine());

            double result = PerformOperation(num1, num2, choice);
            if (!double.IsNaN(result))
            {
                Console.WriteLine($"Result: {result}");
            }

            Console.WriteLine("\n2. Tables between the two numbers:");
            PrintTables(num1, num2);

            Console.WriteLine("\n3. Prime numbers between the two numbers:");
            PrintPrimeNumbers(num1, num2);
        }

       
        static double PerformOperation(int n1, int n2, int choice)
        {
            double result = 0;

            switch (choice)
            {
                case 1: 
                    result = n1 + n2;
                    Console.WriteLine("Performing Addition");
                    break;

                case 2: 
                    result = n1 - n2;
                    Console.WriteLine("Performing Subtraction");
                    break;

                case 3: 
                    result = n1 * n2;
                    Console.WriteLine("Performing Multiplication");
                    break;

                case 4: 
                    if (n2 != 0)
                    {
                        result = (double)n1 / n2;
                        Console.WriteLine("Performing Division");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        result = double.NaN;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    result = double.NaN;
                    break;
            }

            return result;
        }

        
        static void PrintTables(int n1, int n2)
        {
            int start = Math.Min(n1, n2);
            int end = Math.Max(n1, n2);

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"Table of {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }

        
        static void PrintPrimeNumbers(int n1, int n2)
        {
            int start = Math.Min(n1, n2);
            int end = Math.Max(n1, n2);

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
