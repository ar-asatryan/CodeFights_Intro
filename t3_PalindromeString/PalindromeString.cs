using System;

namespace t3_PalindromeString
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            string inpStr = Console.ReadLine();
            Console.WriteLine(PalindromeString.CheckPalindrome(inpStr) );
        }

        static bool CheckPalindrome(string inputString)
        {
            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            return new string(arr) == inputString;
        }
    }
}
