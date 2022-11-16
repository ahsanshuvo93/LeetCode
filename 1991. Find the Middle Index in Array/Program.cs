using System;

namespace _1991._Find_the_Middle_Index_in_Array
{
    class Program
    {
        // Date : 16/November/2022
        // Problem Name : 1991. Find the Middle Index in Array
        // Topic : Prefix Sum
        // URL : https://leetcode.com/problems/find-the-middle-index-in-array/
        // Status : My Solution
        // Level : Easy

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] array = new int[] { 0 };

            Console.WriteLine(FindMiddleIndex(array));

            Console.ReadKey();
        }

        static public int FindMiddleIndex(int[] nums)
        {
            try
            {
                nums = RunningSum(nums);

                int pivotPosition = SearchPivotIndex(nums);

                return pivotPosition;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // Method To Get the Running Sum of An Array
        static int[] RunningSum(int[] nums)
        {
            try
            {
                for (int i = 1; i < nums.Length; i++)
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

        // Linear Search Return the index number from the array
        static int SearchPivotIndex(int[] nums)
        {
            try
            {
                int R = nums.Length - 1;

                if (R == 0)
                {
                    return 0;
                }

                if (nums[R] - nums[0] == 0 && R > 0)
                {
                    return 0;
                }

                for (int i = 1; i <= R; i++)
                {
                    if (nums[i - 1] == (nums[R] - nums[i]))
                    {
                        return i;
                    }
                }


                return -1;      // Return the index of target number. If it is not exist return -1
            }
            catch (Exception ex)
            {

                throw;

            }
        }
    }
}
