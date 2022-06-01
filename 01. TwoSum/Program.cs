using System;

namespace _01._TwoSum
{
    class Program
    {
        // Date : 26/May/2022
        // Problem Name : Two Sum
        // Topic : Array/String
        // URL : https://leetcode.com/problems/two-sum/
        // Status : My Solution
        // Level : Easy
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] intArray = new int[] { 2, 7, 11, 15 };
            //Console.WriteLine(TwoSum(intArray, 9));

            var result = TwoSum(intArray, 9);

            string output = String.Empty;

            foreach (var res in result)
            {
                output = output + res + ",";
            }

            output = output.Remove(output.Length - 1, 1);


            Console.WriteLine(output);

            Console.ReadKey();
        }


        // Method of Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            //Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return nums;
        }
    }
}
