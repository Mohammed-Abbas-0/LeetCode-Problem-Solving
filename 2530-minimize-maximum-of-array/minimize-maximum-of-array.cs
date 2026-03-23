public class Solution
{
    public int MinimizeArrayValue(int[] nums)
    {
        
        int ans = 0;
        long prefixSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];

            int average = (int)((prefixSum + i) / (i + 1)); 
            ans = Math.Max(average ,ans);
        }
        return ans;
    }
}