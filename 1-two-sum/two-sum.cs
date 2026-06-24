public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dic = new();
        for(int i = 0; i < nums.Length; i++)
        {
            int res = target - nums[i];
            if(dic.ContainsKey(res))
                return new int[]{dic[res],i};
            dic[nums[i]] = i;
        }
        return new int[]{0,1};
    }
}