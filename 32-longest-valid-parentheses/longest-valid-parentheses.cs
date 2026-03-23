public class Solution {
    public int LongestValidParentheses(string s) {
         Stack<int> stack = new Stack<int>();
 stack.Push(-1);
 int maxLength = 0;
 for(int i = 0; i < s.Length; i++)
 {
     if (s[i] == '(')
     {
         stack.Push(i);
     }
     else
     {
         stack.Pop();
         if (stack.Count > 0)
         {
             int currentLength = i - stack.Peek();
             maxLength = Math.Max(maxLength, currentLength);
         }
         else
         {
             stack.Push(i);
         }
     }
 }
 return maxLength;
    }
}