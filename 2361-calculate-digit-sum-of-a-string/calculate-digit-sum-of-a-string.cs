
public class Solution {
    public string DigitSum(string s, int k) {

        while (s.Length > k) {

            StringBuilder result = new();

            for (int i = 0; i < s.Length; i += k) {

                int sum = 0;

                for (int j = i; j < Math.Min(i + k, s.Length); j++) {
                    sum += s[j] - '0';
                }

                result.Append(sum);
            }

            s = result.ToString();
        }

        return s;
    }
}
