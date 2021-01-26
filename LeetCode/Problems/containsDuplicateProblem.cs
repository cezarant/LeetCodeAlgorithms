using System;

namespace ConsoleApp1.Problems
{
    public static class containsDuplicateProblem
    {
        public static bool implementation(int[] nums)
        {
            int contDup = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if ((i + 1) < nums.Length)
                    if (nums[i] == nums[i + 1])
                        contDup++;
            }
            return contDup > 0;
        }
    }
}
