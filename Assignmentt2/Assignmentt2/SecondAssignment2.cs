using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt2
{
    internal class SecondAssignment2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string!");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the Second String!");
            string str2 = Console.ReadLine();
            bool isEqual = CompareStrings(str1, str2);
            Console.WriteLine($"1. Are the strings equal? {(isEqual ? "Yes" : "No")}");
            string copiedString = CopyString(str2);
            Console.WriteLine($"2. Copied string: {copiedString}");
            string combinedString = CombineStrings(str1, str2);
            Console.WriteLine($"3. Combined string: {combinedString}");
        }
        static bool CompareStrings(string str1, string str2)
        {
            return str1.Equals(str2);
        }
        static string CopyString(string source)
        {
            return string.Copy(source); 
        }
        static string CombineStrings(string temp1, string temp2)
        {
            return temp1 + temp2; 
        }
    }
}
