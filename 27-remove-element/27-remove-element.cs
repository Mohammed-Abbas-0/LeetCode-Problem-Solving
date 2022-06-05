public class Solution {
    public int RemoveElement(int[] nums, int val) {
            int countNumbersNotDuplicates = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == val)  continue;
            // We will update the array in place
            nums[countNumbersNotDuplicates] = nums[i];
            countNumbersNotDuplicates++;
        }
        return countNumbersNotDuplicates;
    }
    
}