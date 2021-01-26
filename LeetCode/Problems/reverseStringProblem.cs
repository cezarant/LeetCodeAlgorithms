using System;

public static class reverseStringProblem
{
    // Write a function that reverses a string.The input string is given as an array of characters char[].
    // Do not allocate extra space for another array,
    // you must do this by modifying the input array in-place with O(1) extra memory.
    public static char[] implementation(char[] s)
    {
        /*if (s.Length == 0) return s;
        char[] revertedArr = new char[s.Length];
        int cont = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            revertedArr[cont] = s[i];
            cont++;
        }
        return revertedArr;*/
        int i = 0;
        char aux;
        if (s.Length > 0)
        {
            do
            {
                aux = s[i];
                s[i] = s[(s.Length - 1) - i];
                s[(s.Length - 1) - i] = aux;
                i++;
            } while (i < Math.Floor(Convert.ToDecimal(s.Length / 2)));
        }
        return s; 
    }
}

