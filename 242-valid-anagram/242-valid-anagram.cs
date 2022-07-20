public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int Index;
        foreach(char ch in s)
        {
            
            if(t.Contains(ch)) t = t.Remove(t.IndexOf(ch,0),1);
            else return false;
        }
        return true;
        

    }
}
