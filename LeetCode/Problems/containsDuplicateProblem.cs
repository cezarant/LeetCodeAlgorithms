using System;

namespace ConsoleApp1.Problems
{
    // Given an array of integers, find if the array contains any duplicates.
    // Your function should return true if any value appears at least twice in the array, 
    // and it should return false if every element is distinct.
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
