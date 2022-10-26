using System;
using System.Linq;

namespace _645._Set_Mismatch
{
    class Program
    {
        // Date : 26/October/2022
        // Problem Name : 645. Set Mismatch
        // Topic : Array
        // URL : https://leetcode.com/problems/set-mismatch/
        // Status : My Solution
        // Level : Easy

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] nums = { 1, 5, 3, 2, 2, 7, 6, 4, 8, 9 };

            var result = FindErrorNums(nums);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        // Method To Find Duplicate Element and an Appropriate Number From a given array
        static int[] FindErrorNums(int[] nums)
        {
            try
            {
                nums = nums.OrderBy(s=>s).ToArray();

                int temp = 0;

                int[] res = new int[2];

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == nums[i + 1] && res[0] == 0)
                    {
                        res[0] = nums[i];

                        // Swap element in array
                        temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                    else if (res[0] != 0)
                    {
                        // Swap element in array
                        temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                }

                for (int i = 0; i < nums.Length; i++)
                {

                    if (nums[i] != i + 1)
                    {
                        res[1] = i + 1;

                        return res;
                    }
                }

                return res;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
