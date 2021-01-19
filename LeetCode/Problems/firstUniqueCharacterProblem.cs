namespace ConsoleApp1.Problems
{
    public static class firstUniqueCharacterProblem
    {
        public static int implementation(string s)
        {
            var charAndCount = new int[256];

            foreach (var c in s)
            {
                charAndCount[c]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charAndCount[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
