public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char,int> dic = new();
        for(int i = 0; i < s.Length; i++)
        {
           if(dic.ContainsKey(s[i]))
            dic[s[i]]++;
        else
            dic[s[i]] = 1;
        }
         for(int i = 0; i < t.Length; i++)
        {
            
            if(dic.ContainsKey(t[i])){
                dic[t[i]]--;
             if(dic[t[i]] < 0) return false;
            }
            else
                return false;
        }

        return true;
    }
}