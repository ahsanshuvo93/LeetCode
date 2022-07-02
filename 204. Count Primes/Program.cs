using System;
using System.Collections.Generic;

namespace _204._Count_Primes
{
    class Program
    {
        // Date : 02/July/2022
        // Problem Name : 204. Count Primes
        // Topic : Prime Number
        // URL : https://leetcode.com/problems/count-primes/
        // Status : My Solution
        // Level : Medium

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int s = 410;

            //var result = CountPrimes(s);
            var Sieveresult = SieveOfEratosthenes(s);

            //Console.WriteLine(result);
            Console.WriteLine(Sieveresult);
            Console.ReadKey();
        }

        // Method of Sieve Of Eratosthenes to Count Prime Number less than n
        static int SieveOfEratosthenes(int n)
        {
            try
            {
                bool[] numbers = new bool[n+1];

                // Mapping true of all index from 2 to (n-1)
                for (int i = 2; i<n; i++)
                {
                    numbers[i] = true;
                }

                for (int i = 2; i*i<n; i++)
                {
                    if (numbers[i] == true)
                    {
                        // Update all multiples of i
                        for (int j = i * i; j <n; j = j +i)
                        {
                            numbers[j] = false;
                        }
                    }
                }

                int ans = 0;

                for (int i = 2; i < n; i++)
                {
                    if (numbers[i] == true)
                        ans++;
                }

                return ans;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        // Got TLE with this Solution
        static int CountPrimes(int n)
        {
            try
            {
                int result = 0;

                for (int i = 2; i < n; i++)
                {
                    bool flag = true;

                    //for (int k = 2; k <= i / 2; k++)      // Got TLE with this iteration
                    for (int k = 2; (k * k) <= i; k++)      // (K*k <= i) is used instead of (k <= i / 2) due to reduce execution time
                    {
                        if (i % k == 0)
                        {
                            // "Not Prime";
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        // "Prime";
                        result++;
                    }
                }

                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }        
    }
}
