public class Solution {
    public int Compress(char[] chars) {
       if(chars.Length == 1) return 1;
	   int i=0, CountIndex=0;
	   while(i < chars.Length)
	   {
	   		int j = i;
			while(j < chars.Length && chars[j] == chars[i])
			{
				j++;
			}
			
			chars[CountIndex++] = chars[i];	
			if(j - i > 1)
			{
				string count = j - i + "";
				foreach (char ch in count.ToCharArray())  
				{
					chars[CountIndex++] = ch;
				}
			}
			
			i = j;
			
	   }
        return CountIndex;
       
    }
}