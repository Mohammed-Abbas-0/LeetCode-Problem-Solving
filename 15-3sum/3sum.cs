// Input: nums = [-1,0,1,2,-1,-4]
// Output: [[-1,-1,2],[-1,0,1]]

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums); // -4 -1 -1 0 1 2
        List<IList<int>> lst = new();
        for(int i = 0; i < nums.Length;  i++)
        {
            int left = i+1,right = nums.Length-1;
            if(i > 0 && nums[i] == nums[i-1]) continue;
            while(left < right)
            {
                if(nums[i] + nums[left] + nums[right] == 0)
                {
                    lst.Add(new List<int>{nums[i],nums[left] , nums[right]});
                    right--;
                    left++;
                    while(left < right && nums[left] == nums[left-1]) left++;
                    while(left < right && nums[right] == nums[right+1]) right--;
                }
                else if(nums[i] + nums[left] + nums[right] < 0)
                    left++;
                else
                    right--;
            } 

           
        }
        return lst;
    }
}