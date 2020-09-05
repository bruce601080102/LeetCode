/*
Runtime: 260 ms, faster than 73.28% of C# online submissions for How Many Numbers Are Smaller Than the Current Number.
Memory Usage: 32 MB, less than 25.97% of C# online submissions for How Many Numbers Are Smaller Than the Current Number.
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
            
            //array
            int[] nums = new int[5] { 8, 1, 2, 2, 3 };
            
            Console.WriteLine(sol.SmallerNumbersThanCurrent(nums));
            Console.Read();
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {

            List<int> result_list = new List<int>();
            foreach (int i in nums) {
                int sum_result = 0;
                for (int ii =0; ii<nums.Length;ii++) {
                    if (i>nums[ii]) {

                        sum_result += 1;

                    }
                }
                result_list.Add(sum_result);
            }

            return result_list.ToArray();




        }

    }
}


