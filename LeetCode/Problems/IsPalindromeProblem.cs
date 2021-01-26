using System;

namespace ConsoleApp1.Problems
{
  public static class IsPalindromeProblem
  {
    // Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
    // Note: For the purpose of this problem, we define empty string as valid palindrome.
    public static bool implementation(string s)
    {
      int left = 0, right = s.Length - 1;
      do
      {
        if (!char.IsLetterOrDigit(s[left]))
          left++;
        else if (!char.IsLetterOrDigit(s[right]))
          right--;
        else
        {
          if (char.ToLower(s[left]) != char.ToLower(s[right]))
            return false;

          left++;
          right--;
        }
      } while (left < right);

      return true;       
    }
  }
}
