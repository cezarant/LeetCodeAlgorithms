using System;

public static class reverseStringProblem
{
    // Write a function that reverses a string. The input string is given as an array of characters char[].
    // Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
    // You may assume all the characters consist of printable ascii characters.
    public static char[] implementation(char[] s)
    {
        // Example: cezar -> razec
        // cezar -> aux:c 
        // cezar -> c:r 
        // rezar -> r:c 
        // rezac.... 
        char  aux = ' ';
        int cont = 0; 
        do
        {
            aux = s[s.Length - (cont+1)];
            s[s.Length - (cont + 1)] = s[cont];
            s[cont] = aux;            
            cont++; 
        } while ((cont+ 1 ) < s.Length);        
        return s; 
    }
}

