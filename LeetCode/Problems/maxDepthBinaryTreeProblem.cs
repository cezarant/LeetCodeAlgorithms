using System;
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
    // Given the root of a binary tree, return its maximum depth.
    // A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.   
    public static int implementation(TreeNode root)
    {
        if (root == null)
            return 0;
        
        int leftDef = implementation(root.left); 
        int rightDef = implementation(root.right);
        if (leftDef > rightDef) 
            return (leftDef + 1); 
        else 
            return (rightDef + 1);  
    }
}