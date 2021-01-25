using System;
using System.Linq;

public static class validAnagramProblem
{
    public static bool implementation(string s, string t)
    {
        char[] arr1 = s.ToCharArray();
        char[] arr2 = t.ToCharArray();
       
        Array.Sort(arr1);
        Array.Sort(arr2);
        return arr1.SequenceEqual(arr2);
    }
}

