public class Solution {
    public int RemoveElement(int[] nums, int val) {
            int countNumbersNotDuplicates = 0;
        // Loop for all the elements in the array
        for (int i = 0; i < nums.Length; i++) {
            // If the current element is equal to the next element, we skip
            if (nums[i] == val) {
                continue;
            }
            // We will update the array in place
            nums[countNumbersNotDuplicates] = nums[i];
            countNumbersNotDuplicates++;
        }
        return countNumbersNotDuplicates;
    }
    
}