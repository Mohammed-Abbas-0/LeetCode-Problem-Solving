public class Solution
{
    public int LongestSquareStreak(int[] nums)
    {
     int maxStreak = -1;
            HashSet<int> hash = new HashSet<int>(nums);
          
            foreach(int num in nums)
            {
                int current = num;
                int streakLength = 0;
                while(hash.Contains(current))
                {
                    streakLength++;
                    long squreExisted = (long)current * current;
                    if (!hash.Contains((int)squreExisted) || squreExisted > int.MaxValue)
                        break;
                    current = (int)squreExisted;
                }
                if(streakLength > 1)
                    maxStreak = Math.Max(maxStreak,streakLength);
            }

            return maxStreak;       
    }
}
