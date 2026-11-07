/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private int result = 0;
        private int count = 0;

    public int KthSmallest(TreeNode root, int k)
    {
       InorderPattern(root, k);
       return result;
    }
   
   private void InorderPattern(TreeNode root,int k)
   {

     if(root == null) return;
     InorderPattern( root.left, k); // left
     count++;
     if(count == k) result = root.val;
     InorderPattern( root.right, k); //right
   }

    
}