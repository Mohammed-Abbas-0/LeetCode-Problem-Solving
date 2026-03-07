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
    private List<int> nodes;
    public IList<int> PostorderTraversal(TreeNode root) {
        nodes = new();
        DFS(root);
        return nodes;
    }
    private void DFS(TreeNode curr)
    {
        if(curr is null) return;
        DFS(curr.left);
        DFS(curr.right);
        nodes.Add(curr.val); // base
    }
}