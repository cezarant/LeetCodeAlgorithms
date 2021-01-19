using System;

namespace ConsoleApp1.Problems
{
    public static class missingNumberProblem
    {
        public static int implementation(int[] nums)
        {
            Array.Sort(nums);

            if (nums[nums.Length - 1] != nums.Length)
                return nums.Length;
            else if (nums[0] != 0)
                return 0;

            for (int i = 1; i < nums.Length; i++)
            {
                int expectedNum = nums[i - 1] + 1;
                if (nums[i] != expectedNum)
                    return expectedNum;
            }
            return -1;
        }
    }
}
