public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new();
        for(int i = 0; i < nums.Length; i++){
            int res = target - nums[i];
            if(map.ContainsKey(res))
                return new int[] {map[res], i}; 
            map[nums[i]] = i;
    
        }
        return new int[]{0,1};
    }
}