
public class Solution {
    public string DigitSum(string s, int k)
    {
        while (s.Length > k)
        {
            s = BuildString(s, k);
        }

        return s;
    }

    private string BuildString(string s, int k)
    {
        StringBuilder str = new();

        for (int i = 0; i < s.Length; i += k)
        {
            int sum = 0;

            for (int j = i; j < Math.Min(i + k, s.Length); j++)
            {
                sum += s[j] - '0';
            }

            str.Append(sum);
        }

        return str.ToString();
    }
}
