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
    private List<int> node;
    public IList<int> InorderTraversal(TreeNode root) {
        node = new();
        DFS(root);
        return node;
    }
    private void DFS(TreeNode curr)
    {
        if(curr is null) return; // base
        DFS(curr.left);
        node.Add(curr.val);
        DFS(curr.right);
    }
}