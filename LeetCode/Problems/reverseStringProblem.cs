namespace leetCode.Problems
{
    public static class reverseStringProblem
    {
        public static char[] implementation(char[] s)
        {
            if (s.Length == 0) return s;
            int cont = 0;
            char aux = char.MinValue;
            do
            {
                aux = s[cont];
                s[cont] = s[s.Length - (cont + 1)];
                s[s.Length - (cont + 1)] = aux;
                cont++;
            } while (cont < (s.Length-1));
            return s;
        }
    }
}
