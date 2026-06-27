public class Solution {
    public int MaxSubArray(int[] nums) {
        int currentSum  = 0, maxSum = nums[0];
        for(int i = 0; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);

        }
        return maxSum;
    }
}