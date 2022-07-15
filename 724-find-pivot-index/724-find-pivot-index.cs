public class Solution {
    public int PivotIndex(int[] nums) {
        int Sum = 0,i=0,rightSum=nums.Length-1,leftSum=0;
        // Find Sum of Array
        foreach(int x in nums) Sum += x;
        while(i < nums.Length)
        {
            leftSum+=nums[i];
            if(leftSum == rightSum || (Sum - leftSum == 0 && i==0)) return i;
            rightSum = Sum - leftSum;
            i++;
        }
        return -1;
    }
}