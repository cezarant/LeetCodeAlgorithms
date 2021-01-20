

namespace ConsoleApp1.Problems
{
    public static class IsPalindromeProblem
    {
        public static bool implementation(string s)
        {
            var n = s.Length;
            var left = 0;
            var right = n - 1;

            while (left < right)
            {
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                else
                {
                    if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
            }
            return true;            
        }
    }
}
