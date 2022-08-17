using System;

namespace _12._Integer_to_Roman
{
    class Program
    {
        // Date : 17/August/2022
        // Problem Name : 12. Integer to Roman
        // Topic : Math
        // URL : https://leetcode.com/problems/integer-to-roman/
        // Status : My Solution
        // Level : Medium

        public static string Answer { get; set; } = String.Empty;

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int s = 2175;       //MMCLXXV
            //int s = 9646324351;
            //int s = 1110;
            int s = 9;
            //int s = 1110;

            var result = IntToRoman(s);            

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string IntToRoman(int num)
        {
            try
            {
                Answer = String.Empty;
                int r = 0;
                int store = 0;

                for (int i = 1; i <= num.ToString().Length; i++)
                {
                    int m = Convert.ToInt32(Math.Pow(10, i));
                    r = (num % m);
                    r = r - store;
                    
                    ConversionInRoman(r);
                    store = (num % m);
                }

                return Answer;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // Method to Convert Interger to Roman (1 <= num <= 3999)
        static string ConversionInRoman(int x)
        {
            try
            {
                int length = x.ToString().Length;

                if (length == 1)
                {
                    if (x == 1)
                    {
                        Answer = Answer + "I";
                    }

                    if (x == 2)
                    {
                        Answer = Answer + "II";
                    }

                    if (x == 3)
                    {
                        Answer = Answer + "III";
                    }

                    if (x == 4)
                    {
                        Answer = Answer + "IV";
                    }

                    if (x == 5)
                    {
                        Answer = Answer + "V";
                    }

                    if (x == 6)
                    {
                        Answer = Answer + "VI";
                    }

                    if (x == 7)
                    {
                        Answer = Answer + "VII";
                    }

                    if (x == 8)
                    {
                        Answer = Answer + "VIII";
                    }

                    if (x == 9)
                    {
                        Answer = Answer + "IX";
                    }
                }

                if (length == 2)
                {
                    
                    if (x < 40)
                    {
                        for (int i = 0; i < x / 10; i++)
                        {
                            Answer = "X" + Answer;
                        }
                    }

                    if (x >= 40 && x < 50)
                    {

                        Answer = "XL" + Answer;
                    }

                    if (x >= 50 && x < 90)
                    {
                        x = x - 50;

                        for (int i = 0; i < x / 10; i++)
                        {
                            Answer = "X" + Answer;
                        }

                        Answer = "L" + Answer;
                    }

                    if (x >= 90)
                    {
                        Answer = "XC" + Answer;
                    }
                }

                if (length == 3)
                {

                    if (x < 400)
                    {
                        for (int i = 0; i < x / 100; i++)
                        {
                            Answer = "C" + Answer;
                        }
                    }

                    if (x >= 400 && x < 500)
                    {

                        Answer = "CD" + Answer;
                    }

                    if (x >= 500 && x < 900)
                    {
                        x = x - 500;

                        for (int i = 0; i < x / 100; i++)
                        {
                            Answer = "C" + Answer;
                        }

                        Answer = "D" + Answer;
                    }

                    if (x >= 900)
                    {
                        Answer = "CM" + Answer;
                    }
                }

                if (length == 4)
                {

                    if (x < 4000)
                    {
                        for (int i = 0; i < x / 1000; i++)
                        {
                            Answer = "M" + Answer;
                        }
                    }

                }

                return Answer;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
