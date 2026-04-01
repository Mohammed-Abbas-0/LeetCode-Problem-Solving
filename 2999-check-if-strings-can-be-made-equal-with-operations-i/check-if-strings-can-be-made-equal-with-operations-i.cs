public class Solution
{
    public bool CanBeEqual(string s1, string s2)
 {
     if (s1.Length != s2.Length)
         return false;

     string s1Even = "" + s1[0] + s1[2];
     string s1Odd = "" + s1[1] + s1[3];

     string s2Even = "" + s2[0] + s2[2];
     string s2Odd = "" + s2[1] + s2[3];

     char[] a1 = s1Even.ToCharArray();
     char[] a2 = s1Odd.ToCharArray();
     char[] b1 = s2Even.ToCharArray();
     char[] b2 = s2Odd.ToCharArray();

     Array.Sort(a1);
     Array.Sort(a2);
     Array.Sort(b1);
     Array.Sort(b2);

     return new string(a1) == new string(b1) &&
                  new string(a2) == new string(b2);
 }
}