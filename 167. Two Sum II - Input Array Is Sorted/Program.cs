using System;

namespace _167._Two_Sum_II___Input_Array_Is_Sorted
{
    class Program
    {
        // Date : 10/June/2022
        // Problem Name : 167. Two Sum II - Input Array Is Sorted
        // Topic : Binary Search
        // URL : https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        // Status : My Solution
        // Level : Medium

        static void Main(string[] args)
        {
            int[] intArray = new int[] { 0, 0, 4, 4 };

            int target = 8;

            var result = TwoSumBinarySearch(intArray, target);

            string output = String.Empty;

            foreach (var res in result)
            {
                output = output + res + ",";
            }

            output = output.Remove(output.Length - 1, 1);


            Console.WriteLine(output);

            Console.ReadKey();
        }

        // Get Two Sum with Binary Search from the Sorted array
        static int[] TwoSumBinarySearch(int[] nums, int target)
        {
            try
            {
                int L = 0;

                int R = nums.Length - 1;

                while (L < R)
                {
                    if (R > nums.Length - 1)
                    {
                        R = nums.Length - 1;
                    }

                    if ((nums[L] + nums[R]) == target)
                    {
                        return new int[] { L + 1, R + 1 };
                    }
                    else if((nums[L] + nums[R]) < target)
                    {

                        L++;
                        R++;
                    }
                    else
                    {
                        R--;
                    }

                }

                return new int[] { - 1, - 1 };
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
