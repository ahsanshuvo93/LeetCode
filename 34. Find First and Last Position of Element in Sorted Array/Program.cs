using System;

namespace _34._Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    class Program
    {
        // Date : 06/June/2022
        // Problem Name : 34. Find First and Last Position of Element in Sorted Array
        // Topic : Binary Search
        // URL : https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
        // Status : My Solution
        // Level : Medium

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] array = new int[] {2,2,3,4,4,4,4,4,8,9,9 };
            int target = 3;

            //Console.WriteLine(SearchRange(array, target));

            var result = SearchRange(array, target);

            string output = String.Empty;

            foreach (var res in result)
            {
                output = output + res + ",";
            }

            output = output.Remove(output.Length - 1, 1);

            Console.WriteLine(output);
            Console.ReadKey();
        }

        // Method to Search Range Using Binary Search
        static int[] SearchRange(int[] nums, int target)
        {
            try
            {
                int L = 0;
                int R = nums.Length - 1;
                int x = -1;
                x = Array.IndexOf(nums, target);
                while (L < R)
                {
                    int M = (L + R) / 2;    // Average of two initial & final index

                    if ((nums[L] == target))
                    {
                        x = L;
                    }
                    if ((nums[R] == target))
                    {
                        x = R;
                    }

                    if (nums[M] < target) 
                    {
                        L = M + 1;      // Narrow down the left index
                    }
                    else if(nums[M] != nums[M + 1])
                    {
                        R = M;          // Narrow down the right index
                    }
                    else
                    {
                        if ((nums[L] == target) && (target == nums[R]))
                        {
                            L = Array.IndexOf(nums, target);
                            return new int[] { L, R };
                        }                      
                        else if(nums[L] < target)
                        {
                            L++;
                        }
                        else
                        {
                            R--;
                        }
                    }
                }

                return new int[] { x, x };
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
