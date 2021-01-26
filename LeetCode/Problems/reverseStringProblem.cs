public static class reverseStringProblem
{
  // Write a function that reverses a string.The input string is given as an array of characters char[].
  // Do not allocate extra space for another array,
  // you must do this by modifying the input array in-place with O(1) extra memory.
  public static char[] implementation(char[] s)
  {
    if (s.Length == 0) return s;
    char aux = char.MinValue;
    int cont = 0;
    do
    {
      aux = s[cont];
      s[cont] = s[s.Length - (cont + 1)];
      s[s.Length - (cont + 1)] = aux;

      cont++;
    } while (cont < s.Length);
    return s;
  }
}

