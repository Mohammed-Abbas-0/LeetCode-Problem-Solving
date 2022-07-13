public class Solution {
    public int FindMiddleIndex(int[] nums) {
        int leftSum =0, RightSum=0;
        int i=0,r=nums.Length-1;
        foreach(int x in nums) RightSum += x;
        while(i < nums.Length)
        {            
            RightSum -= nums[i];
            if(leftSum == RightSum) return i;
            leftSum += nums[i];
            i++;
        }
        return -1;        
    }
}
