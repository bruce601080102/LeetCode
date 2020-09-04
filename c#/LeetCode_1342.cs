using System;

/*
Runtime: 40 ms, faster than 80.85% of C# online submissions for Number of Steps to Reduce a Number to Zero.
Memory Usage: 14.5 MB, less than 79.85% of C# online submissions for Number of Steps to Reduce a Number to Zero.
 
 */
namespace UnitTestProject1
{

    public class UnitTest1
    {
        public static void Main()
        {
            var sol = new UnitTest1();

            Console.WriteLine(sol.NumberOfSteps(14));
            Console.Read();

        }

        public int NumberOfSteps(int num)
        {
            int sum_result = 1;
            

            while (num/2 > 0)
            {
                if (num % 2 == 1)
                {
                    num -= 1;
                    sum_result += 1;
                }
                else {
                    num /= 2;
                    sum_result += 1;
                }
            }
            if (num==0) {
                sum_result = 0;
            }

            return sum_result;
        }

    }
}
