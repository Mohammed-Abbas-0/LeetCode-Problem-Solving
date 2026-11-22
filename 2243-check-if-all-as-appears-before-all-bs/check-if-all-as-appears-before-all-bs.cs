public class Solution {
    public bool CheckString(string s) {
        bool seenB = false;

        foreach (char c in s)
        {
            if (c == 'b')
                seenB = true;

            if (c == 'a' && seenB)
                return false;
        }

        return true;
    }
}