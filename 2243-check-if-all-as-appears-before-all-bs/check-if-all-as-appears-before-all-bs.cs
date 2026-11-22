public class Solution {
    public bool CheckString(string s) {
        bool everyAappersBeforeB = true,bExisting = false;
        int firstB = 0,lastA = 0;
        for(int i =0; i < s.Length; i++)
        {
            if(s[i] == 'b'){
                firstB = i;
                bExisting = true;
                break;
            }
        }
        for(int i =s.Length-1; i > 0; i--)
        {
            if(s[i] == 'a'){
                lastA = i;
                break;
            }
        }

        if(firstB < lastA && bExisting)
            return false;
        return everyAappersBeforeB;
    }
}