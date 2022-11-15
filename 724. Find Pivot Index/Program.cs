using System;

namespace _724._Find_Pivot_Index
{
    class Program
    {
        // Date : 15/November/2022
        // Problem Name : 724. Find Pivot Index
        // Topic : Prefix Sum
        // URL : https://leetcode.com/problems/find-pivot-index/
        // Status : My Solution
        // Level : Easy

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] array = new int[] { 0 }; 

            Console.WriteLine(PivotIndex(array));

            Console.ReadKey();
        }

        static int PivotIndex(int[] nums)
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

                if (nums[R] == 0 && R == 0)
                {
                    return 0;
                }

                if ( nums[R] - nums[0] == 0 && R > 0)
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
