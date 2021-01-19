using System;

namespace ConsoleApp1.Problems
{
    public static class findNumberProblem
    {
        public static int implementation(int[] nums)
        {
            int evenCount = 0;
            foreach (int entry in nums)
                if (Math.Floor(Math.Log10(Math.Abs(entry)) + 1) % 2 == 0)
                    evenCount += 1;

            return evenCount;
        }
    }
}
