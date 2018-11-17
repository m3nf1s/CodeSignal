using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        /*Given the string, check if it is a palindrome.

        Example

        For inputString = "aabaa", the output should be checkPalindrome(inputString) = true;
        For inputString = "abac", the output should be checkPalindrome(inputString) = false;
        For inputString = "a", the output should be checkPalindrome(inputString) = true.*/

        static void Main(string[] args)
        {
            Console.WriteLine(CheckPalindrome("abba"));
            Console.WriteLine(CheckPalindrome("adfg"));

        }

        static bool CheckPalindrome(string inputString)
        {
            int count = 0;
            for (int i = 0; i < inputString.Length; i++)
                if (inputString[i] == inputString[inputString.Length - i - 1])
                    count++;
            if (count == inputString.Length)
                return true;
            return false;
        }
    }
}
