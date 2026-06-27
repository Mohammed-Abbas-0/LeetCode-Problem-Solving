public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int left = 0,right=nums.Length-1;
        while(left < right)
        {
            if(nums[left] + nums[right] == target)
                return new int[]{left+1,right+1};
            else if(nums[left] + nums[right] < target)
                left++;
            else right--;        
        }
        return new int[]{0,0};
    }
}