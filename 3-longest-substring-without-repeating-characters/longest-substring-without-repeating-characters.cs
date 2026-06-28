public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0,maxSubString=0,currentSize =0;
        HashSet<char> hash = new();
        for(int i = 0; i < s.Length; i++){
            while(hash.Contains(s[i])){
                hash.Remove(s[left]);
                left++;
            }
            hash.Add(s[i]);
            maxSubString = Math.Max(maxSubString, i - left + 1);
        }
        return maxSubString;
    }
}