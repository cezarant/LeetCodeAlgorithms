
public class TreeNode
{
    public int? val;
    public TreeNode left;
    public TreeNode right;
    private object p;

    public TreeNode(object p)
    {
        this.p = p;
    }

    public TreeNode(int? val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public static class maxDepthBinaryTreeProblem
{
    public static int implementation(TreeNode root)
    {
        if (root == null)
            return 0;

        int leftDepth = implementation(root.left);
        int rightDepth = implementation(root.right);

        if (leftDepth > rightDepth)
            return (leftDepth + 1);
        else
            return (rightDepth + 1);
    }
}

