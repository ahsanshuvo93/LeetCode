using System;

namespace _35._Search_Insert_Position
{
    class Program
    {
        // Date : 01/June/2022
        // Problem Name : 35. Search Insert Position
        // Topic : Binary Search
        // URL : https://leetcode.com/problems/search-insert-position/
        // Status : My Solution
        // Level : Easy

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] array = new int[] { 1, 3, 5, 6 };
            int target = 70;

            Console.WriteLine(BinarySearch(array, target));

            Console.ReadKey();
        }

        static int BinarySearch(int[] nums, int target)
        {
            try
            {
                int L = 0;
                int R = nums.Length - 1;

                if (target > nums[R])
                {
                    return (R + 1);
                }

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
                return L;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
