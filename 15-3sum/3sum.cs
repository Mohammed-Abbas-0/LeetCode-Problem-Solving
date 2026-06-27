public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> lst = new();
        for(int i = 0; i < nums.Length; i++)
        {
            if(i > 0 && nums[i] == nums[i-1]) continue;
            int left = i+1,right = nums.Length-1; 
            while(left < right)
            {
                if(nums[i] + nums[left] + nums[right] == 0)
                {
                    lst.Add(new List<int>{nums[i] ,nums[left] , nums[right]});
                    right--;
                    left++;
                    while(left < right&&nums[left] == nums[left-1]) left++;
                    while(left < right &&nums[right] == nums[right+1]) right--;
                }
                else if(nums[i] + nums[left] + nums[right] > 0) right--;
                else left++;
            }
        }
        return lst;
    }
}