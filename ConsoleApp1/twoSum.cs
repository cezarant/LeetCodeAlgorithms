public class leetCodeAlgorithms
{
    public int[] twoSum(int[] nums, int target)
    {
        int[] returnVector = new int[2];
        bool continueLoop = true;
        bool continueLoopEx = true;
        int i = 0; int j = 0;
        do
        {
            do
            {
                if (nums[j] + nums[i + 1] == target)
                {
                    returnVector[0] = j;
                    returnVector[1] = i + 1;
                    return returnVector;
                }
                if ((i + 1) >= (nums.Length - 1))
                    continueLoop = false;
                else
                    i++;
            } while (continueLoop);
            i = (j + 1);

            if ((j + 1) >= (nums.Length - 1))
                continueLoopEx = false;
            else
            {
                j++;
                continueLoop = true;
            }
        } while (continueLoopEx);
        return returnVector;
    }
}
