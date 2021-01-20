
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Problems
{
    public static class validParentesisProblem
    {
        public static bool implementation(string s){
            if (s == "") return true;

            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (c == ')' && (!stack.Any() || stack.Pop() != '('))
                    {
                        return false;
                    }
                    else if (c == ']' && (!stack.Any() || stack.Pop() != '['))
                    {
                        return false;
                    }
                    else if (c == '}' && (!stack.Any() || stack.Pop() != '{'))
                    {
                        return false;
                    }
                }
            }
            return !stack.Any();
        }
    }
}
