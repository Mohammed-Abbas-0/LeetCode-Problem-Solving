public class Solution {
  
    public int[] RunningSum(int[] nums) {
       int i = 0,sum=0;
        while(i <= nums.Length-1)
        {
            //nums[i] += nums[i-1];
            nums[i] = sum + nums[i];
            sum = nums[i];
            i++;
        }
        return nums;
        
    }
    


}