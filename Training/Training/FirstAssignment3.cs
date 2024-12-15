using System;
using System.Diagnostics;

namespace Training
{
    internal class FirstAssignment3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number from 1 to 10");
            DisplayNumbers();
        }
        static void DisplayNumbers()
        {
            for(int i = 0;i <= 10; i++)
            {
                Debug.WriteLine($"Present number is:{i}");
                Console.WriteLine(i);
            }
        }
        
    }
}
