public class Solution {
    public int[] SearchRange(int[] nums, int target) {
		int[] result = new int[]{-1,-1};
		if (nums.Length == 0) return result;
		result[0] = BinarySearch(nums,target);
		if(nums[result[0]] != target) 
		{
			result[0] = -1;
            return result;
		}
		
		result[1] = BinarySearch(nums,target+1);
		
		if(nums[result[1]] != target) 
		{
			result[1] -= 1;
		}
		return result;
    }
	
	private int BinarySearch(int[] nums, int target)
	{
		int left = 0,right=nums.Length-1;
		while(left < right)
		{
			int mid = (left+right)/2;
			if(nums[mid] >= target) right = mid;
			else left = mid+1;
		}
		return left;
	}
}
