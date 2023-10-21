public class Solution {
    public int MostFrequentEven(int[] nums) {
        
             
            Dictionary<int,int> Dic = new();
            foreach (int val in nums)
            {
                if (!Dic.ContainsKey(val) && val % 2 == 0)
                {
                    Dic.Add(val, 1);

                }
                else
                {
                    if(val % 2 == 0)
                        Dic[val]++;
                }

            }
            if (Dic.Count() == 0)
                return -1;
            int result = int.MaxValue, bigValue = 0;
            foreach(var item in Dic)
            {
                if (Dic[item.Key] >= 1 && Dic[item.Key] >= bigValue)
                {
                    if(Dic[item.Key] > bigValue )
                    {
                        result = item.Key;
                        bigValue = Dic[item.Key];
                    }
                    else
                    {
                        result = Math.Min(item.Key, result);
                        bigValue = Dic[item.Key];

                    }
                }
            }
            return result ;
    }
}