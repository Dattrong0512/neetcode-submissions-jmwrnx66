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
    int diameter = 0;

   public int DiameterOfBinaryTree(TreeNode root) 
    {
        GetHeight(root);
        return diameter;
    }

    private int GetHeight(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }

        int maxLengthLeft = GetHeight(root.left);
        int maxLengthRight = GetHeight(root.right);

        diameter = Math.Max(diameter, maxLengthLeft + maxLengthRight);
        return 1 + Math.Max(maxLengthLeft, maxLengthRight);
    }
}
