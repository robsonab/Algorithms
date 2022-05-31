using System;
using System.Linq;

namespace Algorithms
{
    public static class MathAlgorithms
    {
        public static void Swap(ref int a,ref int b)
        {
            //a = 10;
            //b = 20;

            a = a + b; // 30 
            b = a - b; // 10
            a = a - b; // 20
        }

        public static int FindMissingNumber(int[] nums, int n)
        {
            var total = (n + 1) * (n + 2) / 2;
            var sum = nums.Sum();
            return total - sum;
        }

        public static int FindMissingNumber(int[] nums)
        {
            var total = 1;
            var sum = 0;

            for (int i = 2; i <= nums.Length+1; i++)
            {
                total += i;
                sum += nums[i-2];
            }

            return total - sum;
        }
    }
}
