public static class singleNumberProblem
{
    public static int implementation(int[] nums){
                
        int i = 0;
        int j = nums.Length - 1;
        int aux = 0;
        int cont = 0; 
        int choosenOne = 0;
        
        if (nums.Length == 1)
            return nums[0];

        do
        {
            do
            {
                if (nums[i] == nums[j])
                {
                    aux = nums[i + 1];
                    nums[i + 1] = nums[j];
                    nums[j] = aux;
                    cont++;
                }
                j--;
            } while (j > 0);
                        
            if (cont == 0)
            {
                choosenOne = nums[i];
                i = nums.Length;
            }
            else
            {
                i += 2;
                j = nums.Length - 1;
                choosenOne = nums[i];
            }           
        } while (i < (nums.Length -1));
        return choosenOne;         
    }
}

