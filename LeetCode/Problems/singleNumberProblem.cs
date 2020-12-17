using System;

public static class singleNumberProblem
{
    public static int implementation(int[] nums)
    {
        int ans = 0;
        int len = nums.Length;

        for (int i = 0; i != len; i++)
        {
            Console.Write("ans:{0} XOR {1}", ans, nums[i]);
            ans ^= nums[i];
            Console.Write("=>");
            Console.WriteLine("ans:{0}", ans);
        }
        Console.WriteLine("ans:{0}", ans);
        return ans;
    }
}

