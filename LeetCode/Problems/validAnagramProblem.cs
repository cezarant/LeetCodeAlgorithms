using System;
using System.Linq;
public static class validAnagramProblem
{
    // Given two strings s and t, write a function to determine if t is an anagram of s.
    public static bool implementation(string s, string t)
    {
        char[] arr1 = s.ToCharArray();
        char[] arr2 = t.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);
        return arr1.SequenceEqual(arr2);
    }
}

