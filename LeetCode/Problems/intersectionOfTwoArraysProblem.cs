using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Problems
{
    public static class intersectionOfTwoArraysProblem
    {
        public static int[] implementation(int[] nums1, int[] nums2)
        {
            var nums1Set = new HashSet<int>(nums1);
            var result = new HashSet<int>();

            foreach (var num in nums2)
            {
                if (nums1Set.Contains(num))
                {
                    result.Add(num);
                }
            }
            return result.ToArray();
        }
    }
}
