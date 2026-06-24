
public class Solution {
    public bool ContainsDuplicate(int[] nums) 
    {
        HashSet<int> hash = new();
        for(int i = 0; i < nums.Length; i++)
        {
            if(hash.Contains(nums[i]))
                return true;
            hash.Add(nums[i]);
        }
        return false;
    }
}
