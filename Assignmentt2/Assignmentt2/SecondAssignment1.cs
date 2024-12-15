using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt2
{
    internal class SecondAssignment1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine($"1. Number of characters: {CountCharacters(sentence)}");
            Console.WriteLine($"2. Number of words: {CountWords(sentence)}");
            Console.WriteLine($"3. Reversed sentence: {ReverseSentence(sentence)}");
            Console.WriteLine($"4. Is Palindrome: {(IsPalindrome(sentence) ? "Yes" : "No")}");

            List<int> counts = CountCharacterTypes(sentence);
            Console.WriteLine($"5. Vowels: {counts[0]}, Consonants: {counts[1]}, Digits: {counts[2]}, Special Characters: {counts[3]}");
        }
        static int CountCharacters(string temp)
        {
            return temp.Length; 
        }
        static int CountWords(string temp)
        {
            return temp.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        static string ReverseSentence(string temp)
        {
            return string.Join("", temp.Reverse());
        }

        static bool IsPalindrome(string temp)
        {
            string cleanedSentence = new string(temp.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            string reversedSentence = new string(cleanedSentence.Reverse().ToArray());
            return cleanedSentence == reversedSentence;
        }

        static List<int> CountCharacterTypes(string temp)
        {
            int vowels = 0, consonants = 0, digits = 0, specialCharacters = 0;

            foreach (char c in temp)
            {
                if (char.IsDigit(c))
                {
                    digits++;
                }
                else if ("aeiouAEIOU".IndexOf(c) >= 0)
                {
                    vowels++;
                }
                else if (char.IsLetter(c))
                {
                    consonants++;
                }
                else if (!char.IsWhiteSpace(c))
                {
                    specialCharacters++;
                }
            }

            
            return new List<int> { vowels, consonants, digits, specialCharacters };
        }

    }
}
