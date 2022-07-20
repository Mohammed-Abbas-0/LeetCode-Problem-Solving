public class Solution
{
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length) return false;
        Dictionary<char,int> Dict = new Dictionary<char,int>(); 
        foreach(char i in s)
        {
            if(!Dict.ContainsKey(i)) Dict.Add(i,0); 
            Dict[i]++;
        }
        
        foreach(char i in t)
        {
            if(Dict.ContainsKey(i))
            {
                Dict[i]--;
                if(Dict[i]==0)  Dict.Remove(i); 
                
            }
            else  return false; 
        }
        return Dict.Count == 0;
    }
}