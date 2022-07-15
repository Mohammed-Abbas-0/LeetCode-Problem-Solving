public class Solution {
    public int FindPeakElement(int[] nums) {
        return SearchPeekElement(nums,0,nums.Length-1);
    }
    private int SearchPeekElement(int[] nums,int left,int right)
    {        
        //if(nums[left] == nums[right]) return left;
        while(left < nums.Length)
        {
            if(left == right) return left;
            int mid = (left+right)/2;
            if(nums[mid] < nums[mid+1]) left = mid+1;
            else right = mid;
        }
        return left;
    }
}