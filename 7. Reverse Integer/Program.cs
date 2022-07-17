using System;

namespace _7._Reverse_Integer
{
    class Program
    {
        // Date : 17/July/2022
        // Problem Name : 7. Reverse Integer
        // Topic : Math
        // URL : https://leetcode.com/problems/reverse-integer/
        // Status : My Solution
        // Level : Medium

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int s = 1534236469;
            //int s = 9646324351;

            var result = Reverse(s);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        // Method to return the Reverse Number
        static int Reverse(int x)
        {
            try
            {
                string s = x.ToString();
                string t = String.Empty;

                if (x >= 0)
                {
                    for (int i = (s.Length - 1); i >= 0; i--)
                    {
                        t = t + s[i];
                    }

                    return Convert.ToInt32(t);
                }
                else
                {
                    for (int i = (s.Length - 1); i > 0; i--)
                    {
                        t = t + s[i];
                    }

                    t = "-" + t;

                    return Convert.ToInt32(t);
                }
               
            }
            catch (Exception ex)
            {

                return 0;
            }
        }
    }
}
