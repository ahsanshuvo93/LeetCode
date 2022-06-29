using System;

namespace _9._Palindrome_Number
{
    class Program
    {
        // Date : 29/June/2022
        // Problem Name : 9. Palindrome Number
        // Topic : Palindrome
        // URL : https://leetcode.com/problems/palindrome-number/
        // Status : My Solution
        // Level : Easy

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int s = -121;

            var result = IsPalindrome(s);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        // Method To Check the number IsPalindrome or Not
        static bool IsPalindrome(int x)
        {
            try
            {
                string s = x.ToString();
                string t = String.Empty;

                for (int i = (s.Length - 1); i >= 0; i--)
                {
                    t = t + s[i];
                }

                //Console.WriteLine(s);
                //Console.WriteLine(t);

                if (string.Compare(s, t) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
