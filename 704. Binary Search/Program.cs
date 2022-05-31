using System;

namespace _704._Binary_Search
{
    class Program
    {
        // Date : 31/May/2022
        // Problem Name : 704. Binary Search
        // Topic : Binary Search
        // URL : https://leetcode.com/problems/binary-search/
        // Status : My Solution

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] array = new int[] { -1, 0, 5 };
            int target = 50;

            Console.WriteLine(BinarySearch(array, target));

            Console.ReadKey();
        }

        // Binary Search Return the index number from the array
        static int BinarySearch(int[] nums, int target)
        {
            try
            {
                int L = 0;
                int R = nums.Length - 1;

                while (L < R)
                {
                    int M = (L + R) / 2;    // Average of two initial & final index

                    if (nums[M] < target)
                    {
                        L = M + 1;      // Narrow down the left index
                    }
                    else 
                    {
                        R = M;          // Narrow down the right index
                    }
                    
                }
                return (L == R && nums[L] == target) ? L : -1;      // Return the index of target number. If it is not exist return -1
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
