public class Solution {
    public IList<int> MajorityElement(int[] nums) {
          if (nums.Length == 1)
                return new List<int>() { nums [0]};


            int validAppear = nums.Length / 3;

            Dictionary<int, int> Dic = new();
            IList<int> lst = new List<int>();
            foreach(var item in nums)
            {
                if (!Dic.ContainsKey(item))
                    Dic.Add(item,0);
                else
                {
                    Dic[item]++;
                }
                if (Dic[item] >= validAppear && !lst.Contains(item))
                    lst.Add(item);
            }




            return lst;
    }
}