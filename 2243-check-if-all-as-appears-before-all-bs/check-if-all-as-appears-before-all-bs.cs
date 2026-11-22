public class Solution {
    public bool CheckString(string s) {

        int firstB = -1;
        int lastA = -1;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'b')
            {
                firstB = i;
                break;
            }
        }

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == 'a')
            {
                lastA = i;
                break;
            }
        }

        return firstB == -1 || lastA == -1 || firstB > lastA;
    }
}