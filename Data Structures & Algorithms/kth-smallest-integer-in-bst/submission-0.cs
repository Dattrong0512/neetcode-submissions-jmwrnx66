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
    public int _count = 0;
    public TreeNode _node = null;
    public int KthSmallest(TreeNode root, int k) {
        if(root == null)
        {
            return 0;
        }
        findK(root, k);
        return _node.val;
    }
    public void findK(TreeNode root, int k)
    {
        if(root == null)
        {
            return;
        }

        findK(root.left, k);
        _count++;
        if(_count == k)
        {
            _node = root;
            return;
        }
        findK(root.right, k);
    }
}
