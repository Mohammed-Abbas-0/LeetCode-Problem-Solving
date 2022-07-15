public class Solution {
    public int[] SumZero(int n) {
        int[] arr = new int[n];
        // if n (Even Number)
        if(n % 2  == 0)
        {
            for(int i=0; i < arr.Length; i++)
            {
                arr[i] = i+1;
                arr[i+1] = -(i+1);   
                i++;
            }
        }
        // else n (Odd)
        else
        {
            arr[0]=0;
            for(int i = 1;i<arr.Length;i++)
            {
                arr[i] = i+1;
                arr[i+1] = -(i+1); 
                i++;
            }
        }
        return arr;
    }
}
