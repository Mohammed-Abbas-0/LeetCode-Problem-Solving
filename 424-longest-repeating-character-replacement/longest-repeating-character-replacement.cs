public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> count = new();
        int left = 0, maxCount = 0, maxSize = 0;
        for(int i =0; i < s.Length; i++)
        {
           if(count.ContainsKey(s[i]))
                count[s[i]]++;
            else
                count[s[i]] = 1;
            maxCount = Math.Max(maxCount, count[s[i]]);
            if(i - left + 1 - maxCount > k)
            {
                count[s[left]]--;
                left++;
            }
            
            // ٤. حدّث الـ maxSize
            maxSize = Math.Max(maxSize, i - left + 1);
        }
        return maxSize;
    }
}