
public static class moveZerosProblem
{
    public static int[] implementation(int[] nums)
    {
        int ltz = 0;
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] != 0)
                nums[ltz++] = nums[i];

        for (int i = ltz; i < nums.Length; i++)
            nums[i] = 0;

        return nums;
    }
}

