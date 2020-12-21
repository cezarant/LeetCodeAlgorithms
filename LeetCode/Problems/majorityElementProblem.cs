using System;

public static class majorityElementProblem
{
    public static int implementation(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length / 2;
        return nums[n];
    }
}

