using System;
using System.Linq;

namespace leetCode.Problems
{
    public static class validAnagramProblem
    {
        public static bool implementation(string s, string exp)
        {
            if (s.Length == 0)
                return false;
            
            char[] arr = s.ToCharArray();
            char[] arr2 = exp.ToCharArray();
            Array.Sort(arr);
            Array.Sort(arr2);           
            return arr.SequenceEqual(arr2);
        }
    }
}
