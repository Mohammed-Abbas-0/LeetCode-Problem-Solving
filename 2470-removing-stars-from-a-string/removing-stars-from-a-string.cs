public class Solution {
    public string RemoveStars(string str) {
        Stack<char> stack = new Stack<char>();
        foreach (var c in str)
        {
            if (char.IsLetter(c))
                stack.Push(c);
            if(c == '*')
                stack.Pop();

        }
        return new string(stack.Reverse().ToArray());
    }
}