using System;

namespace _852._Peak_Index_in_a_Mountain_Array
{
    class Program
    {
        // Date : 02/June/2022
        // Problem Name : 852. Peak Index in a Mountain Array
        // Topic : Binary Search
        // URL : https://leetcode.com/problems/peak-index-in-a-mountain-array/
        // Status : My Solution
        // Level : Easy

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] array = new int[] { 0, 10, 5, 2 };

            Console.WriteLine(PeakIndexInMountainArray(array));

            Console.ReadKey();

        }

        // Method To Peak the Index of Mountain Array
        static int PeakIndexInMountainArray(int[] nums)
        {
            try
            {
                int L = 0;
                int R = nums.Length - 1;

                while (L < R)
                {
                    int M = (L + R) / 2;    // Average of two initial & final index

                    if (nums[M] < nums[M+1])
                    {
                        L = M + 1;      // Narrow down the left index
                    }
                    else
                    {
                        R = M;          // Narrow down the right index
                    }

                }

                return R;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
