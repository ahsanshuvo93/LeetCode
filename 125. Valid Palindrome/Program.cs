using System;
using System.Text.RegularExpressions;

namespace _125._Valid_Palindrome
{
    class Program
    {
        // Date : 29/June/2022
        // Problem Name : 125. Valid Palindrome
        // Topic : Palindrome
        // URL : https://leetcode.com/problems/valid-palindrome/
        // Status : My Solution
        // Level : Easy

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //string s = "A man, a plan, a canal: Panama";
            //string s = "12221";
            //string s = "race a car";
            //string s = "1011";
            string s = "A man, a plan, a canal -- Panama";

            var result = IsPalindrome(s);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        // Method To Check the string IsPalindrome or Not
        static bool IsPalindrome(string s)
        {
            try
            {
                s = Regex.Replace(s, "[^A-Za-z0-9 -]", "");
                s = s.Replace("-", "");
                s = s.Replace(" ", "").ToLower();

                string t = String.Empty;

                for (int i = (s.Length - 1); i >= 0; i-- )
                {
                    t = t + s[i];
                }

                //Console.WriteLine(s);
                //Console.WriteLine(t);

                if (string.Compare(s,t) == 0)
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
