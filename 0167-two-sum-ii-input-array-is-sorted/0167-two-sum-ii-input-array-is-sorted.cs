public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if (numbers[0] + numbers[1] == target)
                return new int[] { 1 , 2 };


            int start = 0, end = numbers.Length-1;
            while(start < end)
            {
                if (numbers[start] + numbers[end] == target)
                    return new int[] { start+1, end+1 };
                else if (numbers[start] + numbers[end] > target)
                    end--;
                else
                    start++;
            }
            return new int[] {}; 
    }
}