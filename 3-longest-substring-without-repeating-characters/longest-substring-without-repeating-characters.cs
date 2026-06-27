    public class Solution {
        public int LengthOfLongestSubstring(string s) {
            int left = 0, currentSize = 0, maxSize = 0;
            HashSet<int> hash = new();
            for(int i = 0; i < s.Length; i++){
                while(hash.Contains(s[i]))
                {
                    hash.Remove(s[left]);
                    left++;
                }
            hash.Add(s[i]);
            maxSize = Math.Max(maxSize, i - left + 1);            }
            return maxSize;
        }
    }