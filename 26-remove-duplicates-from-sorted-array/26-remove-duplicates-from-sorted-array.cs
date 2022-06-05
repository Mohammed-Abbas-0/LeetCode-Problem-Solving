public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int countNumbersNotDuplicates = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (i < nums.Length-1 && nums[i] == nums[i + 1]) continue;
            // We will update the array in place
            nums[countNumbersNotDuplicates] = nums[i];
            countNumbersNotDuplicates++;
        }
        return countNumbersNotDuplicates;
    }
}