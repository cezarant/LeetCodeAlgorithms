public static class singleNumberProblem
{
    public static int implementation(int[] nums){
        int ans = 0;
        int len = nums.Length;
        for (int i = 0; i != len; i++)
            ans ^= nums[i];

        return ans;
    }
}

