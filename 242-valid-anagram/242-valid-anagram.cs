public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int Index;
        foreach(char ch in s)
        {
            
            if(t.Contains(ch))
            {
                Index = t.IndexOf(ch,0);
                t   = t.Remove(Index,1);
            }
            else return false;
        }
        return true;
        

    }
}
/*
public class Solution
{
    public bool IsAnagram(string s, string t) 
    {
        var dict = new Dictionary<char,int>(); 
        foreach(var i in s)
        {
            if(!dict.ContainsKey(i)) 
                dict.Add(i,0); 
            dict[i]++;
        }
        
        foreach(var i in t)
        {
            if(dict.ContainsKey(i))
            {
                
                if(dict[i]==0)  dict.Remove(i); 
                dict[i]--;
            }
            else  return false; 
        }
        return dict.Count == 0;
    }
}
*/