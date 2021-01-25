using System;

namespace ConsoleApp1.Problems
{
    public static class containsDuplicateProblem
    {
        public static bool implementation(int[] nums){
            Array.Sort(nums);
            int count = 0; 
            for (int i = 0; i < nums.Length; i++)
            {
                if((i + 1)  < nums.Length) 
                    if (nums[i] == nums[i + 1])
                        count++;
            }
            return count > 0;
        }
    }
}
