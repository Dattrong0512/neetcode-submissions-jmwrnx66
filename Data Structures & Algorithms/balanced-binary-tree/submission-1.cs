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
    public bool IsBalanced(TreeNode root)
    {
        if(root == null)
        {
            return true;
        }
        int leftHeight = HeightTree(root.left);
        int rightHeight = HeightTree(root.right);

        return Math.Abs(leftHeight - rightHeight) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int HeightTree(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        int leftHeight = HeightTree(root.left);
        int rightHeight = HeightTree(root.right);
        return Math.Max(leftHeight, rightHeight) + 1;
    }


}
