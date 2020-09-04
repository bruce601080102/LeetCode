/*
Runtime: 108 ms, faster than 82.80% of C# online submissions for Shuffle String.
Memory Usage: 27.6 MB, less than 71.56% of C# online submissions for Shuffle String.
 
 */
using System;
using System.Collections.Generic;


namespace UnitTestProject1
{

    public class UnitTest1
    {
        public static void Main()
        {
            var sol = new UnitTest1();

            String s = "codeleet";
            
            //array
            int[] indices = new int[8] { 4, 5, 6, 7, 0, 2, 1, 3 };

            Console.WriteLine(sol.RestoreString(s, indices));
            Console.Read();

        }

        public string RestoreString(string s, int[] indices)
        {
            Dictionary<int, char> dict1 = new Dictionary<int, char>();
            List<Char> result = new List<Char>();
            int index = 0;

            foreach (var i in s) {

                dict1.Add(indices[index], i);
                index += 1;
            }

            Array.Sort(indices);
            foreach (int ii in indices) {
                result.Add(dict1[ii]);
            }
            
            return String.Join("", result);
        }

    }
}

