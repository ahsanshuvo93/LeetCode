using System;

namespace _26._Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        // Date : 23/October/2022
        // Problem Name : 26. Remove Duplicates from Sorted Array
        // Topic : Math
        // URL : https://leetcode.com/problems/remove-duplicates-from-sorted-array/
        // Status : My Solution
        // Level : Easy

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] nums = { 0 };

            var result = RemoveDuplicates(nums);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        // Method to Remove Duplicate Elements from an Array
        static int RemoveDuplicates(int[] nums)
        {
            try
            {
                int k = 1;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[k] <= nums[i-1])
                    {
                        nums[k] = nums[i];
                    }
                    if(nums[k - 1] < nums[k])
                    {
                        k++;
                    }
                }

                for (int i = 0; i < nums.Length-1; i++)
                {
                    //Console.WriteLine(nums[i]);
                    if (nums[i] >= nums[i + 1])
                    {
                        return i + 1;
                    }

                }

                return nums.Length;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        
    }
}
