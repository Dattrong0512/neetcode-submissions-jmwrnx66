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
    public int _preIndex = 0;
    public Dictionary<int, int> _dictMap = new Dictionary<int, int>();

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        for(int i = 0; i < inorder.Length; i++)
        {
            _dictMap.Add(inorder[i], i);
        }
        return Build(preorder, 0, inorder.Length - 1);
    }

    public TreeNode Build(int[] preorder, int left, int right)
    {
        if(left > right)
        {
            return null;
        }
        int val = preorder[_preIndex++];
        TreeNode root = new TreeNode(val);
        int mid = _dictMap[val];
        root.left = Build(preorder, left, mid - 1);
        root.right = Build(preorder, mid + 1, right);
        return root;
    }
}

//      1
//    2   3
//  1 2 3
//  2 1 3
//  0 1 2