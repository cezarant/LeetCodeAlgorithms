using System;

namespace ConsoleApp1.Problems
{
    public static class convertSortedArrayBST
    {
        public static TreeNode implementation(int[] arr)
        {
            throw new Exception("Not implemented");
        }
        public static TreeNode helper(int[] num, int low, int high)
        {
            if (low > high)
            { // Done
                return null;
            }
            int mid = (low + high) / 2;
            TreeNode node = new TreeNode(num[mid]);
            node.left = helper(num, low, mid - 1);
            node.right = helper(num, mid + 1, high);
            return node;
        }
        private static TreeNode doItBST(int[] arr, int start, int end)
        {
            if (start > end)
                return null;

            int middle = (start + end) / 2;
            TreeNode treeNode = new TreeNode(arr[middle]);
            treeNode.left = doItBST(arr, start, middle - 1);
            treeNode.right = doItBST(arr, middle + 1, end);
            return treeNode;
        }
    }
}
