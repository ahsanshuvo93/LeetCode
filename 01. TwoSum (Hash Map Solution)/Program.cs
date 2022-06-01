using System;
using System.Linq;

namespace _01._TwoSum__Hash_Map_Solution_
{
    class Program
    {
        // Date : 30/May/2022
        // Problem Name : Two Sum
        // Topic : Array/String
        // URL : https://leetcode.com/problems/two-sum/
        // Status : Hash Map Solution
        // Level : Easy

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] intArray = new int[] { 3,3 };
            int target = 6;
            //Console.WriteLine(TwoSum(intArray, 9));

            var result = TwoSum(intArray, target);

            string output = String.Empty;

            foreach (var res in result)
            {
                output = output + res + ",";
            }

            output = output.Remove(output.Length - 1, 1);


            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];

                if (nums.Contains(temp) && i != Array.IndexOf(nums, temp))
                {
                    return new int[] { i, Array.IndexOf(nums, temp) };
                }
            }

            return nums;
        }
    }
}
