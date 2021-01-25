using System;

public static class reverseStringProblem
{

    public static char[] implementation(char[] s)
    {
        if (s.Length == 0) return s; 
        int cont = 0;
        char aux = ' '; 
        do
        {
            aux = s[s.Length - (cont + 1)];
            s[s.Length - (cont+ 1)] = s[cont];
            s[cont] = aux;
            cont++;
        } while ((cont + 1 ) < s.Length);
        return s;
    }
}

