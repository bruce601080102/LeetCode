/*
Runtime: 88 ms, faster than 90.08% of C# online submissions for Number of Good Pairs.
Memory Usage: 23.9 MB, less than 35.68% of C# online submissions for Number of Good Pairs.
 
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
            int[] indices = new int[6] { 1, 2, 3, 1, 1, 3 };

            Console.WriteLine(sol.NumIdenticalPairs( indices));
            Console.Read();
        }

        public int NumIdenticalPairs(int[] nums)
        {
            int sum_result = 0;
            Dictionary<int, int> dict1 = new Dictionary<int, int>();
            foreach (int i in nums) {
                if (!dict1.ContainsKey(i)){
                    dict1.Add(i, 1);
                }
                else {

                    dict1[i] += 1;
                }
            }
            foreach (int n in dict1.Values) {
                if (n % 2 == 0)
                {
                    sum_result += n * (n/2-1) +(n/2);
                }
                else {
                    sum_result += n * (n / 2); 
                }
            }


            return sum_result;
        }

    }
}


