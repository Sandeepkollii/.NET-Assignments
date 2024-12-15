using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class NumberDisplay
    {
        public void DisplayNumbers()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
    class MultiplicationTable
    {
        public void DisplayTable(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    }
    class CharacterChecker
    {
        public void CheckCharacter(char input)
        {
            if (char.IsLetter(input))
            {
                if ("AEIOUaeiou".IndexOf(input) >= 0)
                    Console.WriteLine($"{input} is a Vowel.");
                else
                    Console.WriteLine($"{input} is a Consonant.");
            }
            else if (char.IsDigit(input))
            {
                Console.WriteLine($"{input} is an Integer.");
            }
            else
            {
                Console.WriteLine($"{input} is a Special Character.");
            }
        }
    }
    
    class PrimeChecker
    {
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
    

    internal class FirstAssignment
    {
        public static void Main(string[] args)
        {
            NumberDisplay que1 = new NumberDisplay();
            que1.DisplayNumbers();

            MultiplicationTable que2 = new MultiplicationTable();
            que2.DisplayTable(6);

            Console.WriteLine("\nEnter a character to check its type:");
            char inp = Console.ReadKey().KeyChar;
            Console.WriteLine(); 
            CharacterChecker que3 = new CharacterChecker();
            que3.CheckCharacter(inp);

            Console.WriteLine("Enter a number to check if it's prime:");
            int number = Convert.ToInt16(Console.ReadLine());
            PrimeChecker que4 = new PrimeChecker();
            bool isPrime = que4.IsPrime(number);
            Console.WriteLine(isPrime ? $"{number} is Prime." : $"{number} is not Prime.");
            Console.ReadLine();

            

        }
    }
}
