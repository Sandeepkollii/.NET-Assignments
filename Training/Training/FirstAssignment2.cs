using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class SumOfNumbers
    {
        public int CalculateSum(int[] numbers)
        {
            if (numbers.Length != 10)
            {
                throw new ArgumentException("Please provide exactly 10 numbers.");
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }

    class SumOfPositiveNumbers
    {
        public int CalculatePositiveSum(int[] numbers)
        {
            int sum = 0, count = 0;
            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    sum += num;
                    count++;
                }
                if (count == 10) break; 
            }
            return sum;
        }
    }

   
    class NameSplitter
    {
        public string[] SplitName(string name)
        {
            return name.Split(' '); 
        }
    }

   
    class VowelCounter
    {
        public int CountVowels(string name)
        {
            int count = 0;
            string vowels = "AEIOUaeiou";

            foreach (char c in name)
            {
                if (vowels.IndexOf(c) >= 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
    internal class FirstAssignment2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers separated by spaces:");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            SumOfNumbers sumOfNumbers = new SumOfNumbers();
            int totalSum = sumOfNumbers.CalculateSum(numbers);
            Console.WriteLine($"Sum of 10 numbers: {totalSum}");

      
            Console.WriteLine("\nEnter numbers (positive and negative) separated by spaces:");
            int[] allNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            SumOfPositiveNumbers positiveSumCalculator = new SumOfPositiveNumbers();
            int positiveSum = positiveSumCalculator.CalculatePositiveSum(allNumbers);
            Console.WriteLine($"Sum of up to 10 positive numbers: {positiveSum}");

            
            Console.WriteLine("\nEnter a name (first and last name):");
            string name = Console.ReadLine();
            NameSplitter nameSplitter = new NameSplitter();
            string[] nameArray = nameSplitter.SplitName(name);
            Console.WriteLine("Name split into array:");
            foreach (string part in nameArray)
            {
                Console.WriteLine(part);
            }

            
            VowelCounter vowelCounter = new VowelCounter();
            int vowelCount = vowelCounter.CountVowels(name);
            Console.WriteLine($"Number of vowels in the name: {vowelCount}");

        }
    }
}
