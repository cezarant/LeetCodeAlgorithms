public static class reverseStringProblem
{
    // Write a function that reverses a string.The input string is given as an array of characters char[].
    // Do not allocate extra space for another array,
    // you must do this by modifying the input array in-place with O(1) extra memory.
    public static char[] implementation(char[] listaCaracteres)
    {
        if (listaCaracteres.Length == 0) return listaCaracteres;
        char[] revertedArr = new char[listaCaracteres.Length];
        int cont = 0;
        for (int i = listaCaracteres.Length - 1; i >= 0 ; i--)
        {
            revertedArr[cont] = listaCaracteres[i];
            cont++; 
        }
        return revertedArr;       
    }
}

