using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Problems
{
    public static class containsDuplicateProblem
    {
        public static bool implementation(int[] nums)
        {            
            Array.Sort(nums);
            int cont = 0; 
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
                cont++;
            }
            return false;
            

            /*int contDup = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if ((i + 1) < nums.Length)
                    if (nums[i] == nums[i + 1])
                        contDup++;
            }
            return contDup > 0;*/
            //var arrSet = new HashSet<int>(nums);            
            // return arrSet.Count != nums.Length;  
            /*for (int i = 0; i < nums.Length; i++)
            {
                if (arrSet.Contains(nums[i]))                                    
                    return true;
                                
                arrSet.Add(nums[i]);
            }
            return false; */
        }
    }
}
