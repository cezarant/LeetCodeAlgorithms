namespace leetCode.Problems
{
    public static class reverseStringProblem
    {
        public static char[] implementation(char[] s)
        {
            int cont = 0;
            char aux = char.MinValue;
            do
            {
                aux = s[s.Length - (cont + 1)];
                s[cont] = s[s.Length - (cont + 1)];
                s[s.Length - (cont + 1)] = aux;
            } while (cont < s.Length);
            return s;
        }
    }
}
