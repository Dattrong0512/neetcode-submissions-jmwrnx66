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
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if(root == null)
        {
            return false;
        }
        if(subRoot == null)
        {
            return true;
        }
        if(IsSameTree(root, subRoot))
        {
            return true;
        }
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool IsSameTree(TreeNode rootA, TreeNode rootB)
    {
        if(rootA == null && rootB == null)
        {
            return true;
        }
        if(rootA == null || rootB == null)
        {
            return false;
        }
        if(rootA.val != rootB.val)
        {
            return false;
        }
        return IsSameTree(rootA.left, rootB.left) && IsSameTree(rootA.right, rootB.right);
    }
}