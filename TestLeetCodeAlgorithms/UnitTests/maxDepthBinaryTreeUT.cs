using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class maxDepthBinaryTreeUT
{
  [TestMethod]
  public void doIt()
  {
    // Input: root = [3, 9, 20, null, null, 15, 7]
    // Output: 3
    var root = new TreeNode(3);
    root.left = new TreeNode(9);
    root.right = new TreeNode(20);
    root.right.right = new TreeNode(15);
    root.right.left = new TreeNode(7);
    verifyIt(root, 3);
    // Input: root = [1, null, 2]
    // Output: 2
    root = new TreeNode(1);
    root.left = new TreeNode(2);
    verifyIt(root, 2);
    // Input: root = []
    // Output: 0            
    verifyIt(null, 0);
    // Input: root = [0]
    // Output: 1
    root = new TreeNode(0);
    verifyIt(root, 1);
  }
  private void verifyIt(TreeNode node, int expected)
  {
    int outPut = maxDepthBinaryTreeProblem.implementation(node);
    outPut.Should().Be(expected);
  }
}

