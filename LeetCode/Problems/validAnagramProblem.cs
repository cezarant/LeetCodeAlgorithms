
using System;
using System.Linq;

public static class validAnagramProblem
{
    public static bool implementation(string s, string t)
    {           
        if ((t.Length - 1) != (s.Length-1))
            return false;

        char[] vetString1 = s.ToCharArray();
        char[] vetString2 = t.ToCharArray();

        Array.Sort(vetString1);
        Array.Sort(vetString2);
                
        return vetString1.SequenceEqual(vetString2);
    }
}

