 public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool IsCousins(TreeNode root, int x, int y)
    {
        return getLarge(root.left) == getLarge(root.right);
    }
    private int getLarge(TreeNode node)
    {
        var i = 1;
        var current = node;
        while (current.left != null && current.right != null)
        {
            i++;
            if (current.left != null)
                current = current.left;
            if (current.right != null)
                current = current.right;
        }
        return i;
    }

}