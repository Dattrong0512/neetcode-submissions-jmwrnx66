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
    public int GoodNodes(TreeNode root)
    {
        return TraverseNode(root, int.MinValue);
    }
    public int TraverseNode(TreeNode root, int greatest)
    {
        if(root == null)
        {
            return 0;
        }
        int count = 0;
        if(root.val >= greatest)
        {
            count = 1;
        }
        greatest = Math.Max(greatest, root.val);
        int leftNode = TraverseNode(root.left, greatest);
        int rightNode = TraverseNode(root.right, greatest);
        return count + leftNode + rightNode;
    }
}
