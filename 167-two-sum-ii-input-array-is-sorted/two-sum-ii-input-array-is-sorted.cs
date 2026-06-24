public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0,right = numbers.Length-1;

        while(left < numbers.Length)
        {
            if(target < numbers[right] + numbers[left])
                right--;
            
            else if(target == numbers[right] + numbers[left])
                return new int[]{left+1,right+1};
            else left++;
        }
                return new int[]{0,1};
    }
}