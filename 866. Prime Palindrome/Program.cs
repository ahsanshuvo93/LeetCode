using System;

namespace _866._Prime_Palindrome
{
    class Program
    {
        // Date : 17/July/2022
        // Problem Name : 866. Prime Palindrome
        // Topic : Palindrome
        // URL : https://leetcode.com/problems/prime-palindrome/
        // Status : My Solution
        // Level : Medium

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int s = 9989900;

            var result = PrimePalindrome(s);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int PrimePalindrome(int n)
        {
            try
            {
                while (n > 0)
                {
                    if (IsPalindrome(n) && IsPrime(n))
                    {
                        return n;
                    }
                    else
                    {
                        n++;
                    }
                    if (10000000 < n && n < 100000000)      // there is no solution number in these range
                    {
                        n = 100000000;
                    }
                }
                
                return 2;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // Method To check the number is palindrome
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

        // Method To check the number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; i++)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
