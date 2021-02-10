using System;

public static class reverseStringProblem
{
    // Write a function that reverses a string.The input string is given as an array of characters char[].
    // Do not allocate extra space for another array,
    // you must do this by modifying the input array in-place with O(1) extra memory.
    public static char[] implementation(char[] s)
    {   
        if (s.Length > 0)
        {
            int cont = 0;
            char aux;
            do
            {
                aux = s[cont];
                s[cont] = s[(s.Length - 1) - cont];
                s[(s.Length - 1) - cont] = aux;
                cont++;
            } while (cont < Math.Floor(Convert.ToDecimal(s.Length / 2)));
        }
        return s; 
    }
}

