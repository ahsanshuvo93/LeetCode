using System;

namespace _1480._Running_Sum_of_1d_Array
{
    class Program
    {
        // Date : 12/November/2022
        // Problem Name : 1480. Running Sum of 1d Array
        // Topic : Prefix Sum
        // URL : https://leetcode.com/problems/running-sum-of-1d-array/
        // Status : My Solution
        // Level : Easy

        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2 };

            var result = RunningSum(intArray);


            foreach (var res in result)
            {
                Console.WriteLine(res);
            }

            //Console.WriteLine("Hello World!");
        }

        static public int[] RunningSum(int[] nums)
        {
            try
            {
                for(int i = 1; i < nums.Length; i++)
                {
                    nums[i] = nums[i] + nums[i - 1];
                }

                return nums;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
