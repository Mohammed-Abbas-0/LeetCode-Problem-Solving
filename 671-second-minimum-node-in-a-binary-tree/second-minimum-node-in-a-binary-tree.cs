
public class Solution
{
    private int smallest;
    private int secondSmallest;
    private bool found;

    public int FindSecondMinimumValue(TreeNode root)
    {
        smallest = root.val;
        found = false;

        DFS(root);

        return found ? secondSmallest : -1;
    }

    private void DFS(TreeNode root)
    {
        if (root == null) return;

        if (root.val > smallest)
        {
            if (!found || root.val < secondSmallest)
            {
                secondSmallest = root.val;
                found = true;
            }

            return;
        }
        DFS(root.right);
        DFS(root.left);
       
    }
}
