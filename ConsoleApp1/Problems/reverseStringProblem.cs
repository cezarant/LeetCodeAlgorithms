using System;

public static class reverseStringProblem
{
    public static char[] implementation(char[] s)
    {
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

