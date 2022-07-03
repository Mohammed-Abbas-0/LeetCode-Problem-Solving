public class Solution {
    public bool IsPalindrome(int x) {
       if(x < 0) return false;
       if(x < 9) return true;
       char[] ch = x.ToString().ToCharArray();
        int left =0,right = ch.Length-1;
       while(left < ch.Length) 
       {
           if(ch[left] != ch[right])
                return false;
           ++left;
           --right;
       }
        return true;
    }
}
