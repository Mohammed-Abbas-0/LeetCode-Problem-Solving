public class Solution {
  
    public int[] RunningSum(int[] nums) {
   /*     int i = 1;
        while(i <= nums.Length-1)
        {
            nums[i] += nums[i-1];
            i++;
        }
        return nums;
        
    }
    */

        int n = nums.Length; //finding out the length of the array using length ATTRIBUTE in java
        int[] runningSum = new int[n];  // creating a new array with the same length as of the input
        runningSum[0] = nums[0];  //running sum of the first element is always equals to the  1st element in input array
        
        int sum = nums[0] + nums[1]; //defining and using sum variable to find out running sum also finding running sum for the 2nd element of the array 
        runningSum[1] = sum;  //assinging the running sum 
        for(int i =2;i<n;i++ ){  // using for loop to calculate the sum beginning from 2 since whe have already found out the running sum for 0th and 1st element
			sum += nums[i]; // calculating the sum
			runningSum[i] = sum; //assinging the sum value in the array with respective position
        }
        return runningSum; //returning the sum array
    }

}