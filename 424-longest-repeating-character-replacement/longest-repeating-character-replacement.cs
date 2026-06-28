public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count = new int[26];
        int left = 0, maxCount = 0, maxSize = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            // ١. ضيف الحرف الجديد
            count[s[i] - 'A']++;
            
            // ٢. حدّث أكتر حرف متكرر
            maxCount = Math.Max(maxCount, count[s[i] - 'A']);
            
            // ٣. لو محتاج تغير أكتر من k → صغّر الـ window
            if(i - left + 1 - maxCount > k)
            {
                count[s[left] - 'A']--;
                left++;
            }
            
            // ٤. حدّث الـ maxSize
            maxSize = Math.Max(maxSize, i - left + 1);
        }
        return maxSize;
    }
}