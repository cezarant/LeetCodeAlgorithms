
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
  public static int implementation(TreeNode root)
  {
    throw new Exception("Not implemented");
  }
}

