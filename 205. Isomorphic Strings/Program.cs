using System;
using System.Collections.Generic;
using System.Linq;

namespace _205._Isomorphic_Strings
{
    class Program
    {
        // Date : 22/November/2022
        // Problem Name : 205. Isomorphic Strings
        // Topic : String
        // URL : https://leetcode.com/problems/isomorphic-strings/
        // Status : My Solution (Using Hashmap Method)
        // Level : Easy

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            string s = "eeee";
            string t = "e";

            var result = IsIsomorphic(s,t);
            Console.WriteLine(result);
            
            Console.ReadKey();
        }
        static bool IsIsomorphic(string s, string t)
        {
            try
            {
                var dict = new Dictionary<char, char>();

                if (s.Length != t.Length)
                {
                    return false;
                }

                for (int i = 0; i < s.Length; i++)
                {
                    char sc = s[i];
                    char st = t[i];

                    if (dict.ContainsKey(sc))
                    {
                        if (st != dict[sc])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (dict.ContainsValue(st))
                        {
                            return false;
                        }
                        dict.Add(sc, st);
                    }
                }
                return true;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
