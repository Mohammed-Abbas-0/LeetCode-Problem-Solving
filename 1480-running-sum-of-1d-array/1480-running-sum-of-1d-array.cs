public class Solution {
  
    public int[] RunningSum(int[] nums) {
       int i = 1;
        while(i <= nums.Length-1)
        {
            nums[i] += nums[i-1];
            i++;
        }
        return nums;       
    }

}