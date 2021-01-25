using System;

namespace ConsoleApp1.Problems
{
    // Given a string, determine if it is a palindrome, 
    // considering only alphanumeric characters and ignoring cases.
    // Note: For the purpose of this problem, we define empty string as valid palindrome.
    public static class IsPalindromeProblem
    {
        public static bool implementation(string s)
        {
            char[] arr = s.Replace(" ",string.Empty).Trim().ToLower().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLetterOrDigit(arr[i]))
                {
                    if (arr[i] != arr[(arr.Length - 1) - i])
                        return false;
                }
            }            
            return true; 
        }
    }
}
