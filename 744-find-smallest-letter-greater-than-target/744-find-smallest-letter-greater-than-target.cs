
class Solution {
    
    private char smallLetter(char[] ch,int left,int right,int target)
    {
        while(left <= right)
        {
            int mid = (left+right) /2;
            if(ch[mid] <= target) return smallLetter(ch,mid+1,right,target);
            if(mid>left && ch[mid-1] > target) 
                return smallLetter(ch,left,mid-1,target);
            return ch[mid];            
        }
        return ch[0];
    }
    public char NextGreatestLetter(char[] letters, char target) {
        return smallLetter(letters,0,letters.Length-1,target);
    }
}
        
        