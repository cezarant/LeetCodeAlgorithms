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
        for (int i = 0; i < s.Length; i++)
        {
            aux = s[s.Length - 1];
            s[i] = aux;
            s[s.Length - 1] = s[i];
        }
        return s; 
    }
}

