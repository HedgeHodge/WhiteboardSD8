using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static bool isPalindrome(string checkStr)
        {
            char[] stringArray = checkStr.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);

            if(reverseString == checkStr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            string input = Console.ReadLine();
            Console.WriteLine(isPalindrome(input.ToLower())); 
        }
    }
}
