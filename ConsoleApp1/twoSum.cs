public class leetCodeAlgorithms
{
    public int[] twoSum(int[] nums, int target)
    {
        int[] returnVector = new int[2];
        bool continueLoop = true;
        int aux = 0; 
        int i = 0;
        do
        {            
            if (nums[i] + nums[i + 1] == target)
            {                
                returnVector[0] = i;
                returnVector[1] = i + 1;
                continueLoop = false;
            }
            if ((i + 1) >= (nums.Length - 1))
                continueLoop = false;
            else
                i++;
        } while (continueLoop);
        return returnVector;
    }
}
