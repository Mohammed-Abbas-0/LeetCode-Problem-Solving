public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hash = new();
        int left = 0, maxLength = 0;
        for(int right = 0; right < s.Length; right++)
        {
            while(hash.Contains(s[right]))
            {
                hash.Remove(s[left]);
                left++;
            }
            hash.Add(s[right]);
            maxLength = Math.Max(maxLength, hash.Count());
        }
        return maxLength;
    }
}