public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] result  = new int[]{-1,-1};
        if(nums.Length == 0) return result;
        int left = 0, right=nums.Length-1;
        while(left <= right)
        {
            int mid = (left+ right) / 2;
            if(nums[mid] == target)
            {
                int start = mid,end = mid;
                while(start >= 0 && nums[start] == target) start--;
                while(end < nums.Length && nums[end] == target) end++;
                return new int[]{start+1, end-1};
            }
            
            else if(nums[mid] < target) left = mid+1;
            else right = mid-1;
        }
        
        return result;
    }
}
