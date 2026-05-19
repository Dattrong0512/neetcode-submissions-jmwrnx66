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
    public List<int> RightSideView(TreeNode root)
    {
        if(root == null)
        {
            return new List<int>();
        }

        Queue<TreeNode> queueNode = new Queue<TreeNode>();
        queueNode.Enqueue(root);
        List<int> returnList = new List<int>();
        while(queueNode.Count > 0)
        {
            int size = queueNode.Count;
            for(int i = 0; i < size; i++)
            {
                TreeNode node = queueNode.Dequeue();
                if(i == size - 1)
                {
                    returnList.Add(node.val);
                }
                if(node.left != null)
                {
                    queueNode.Enqueue(node.left);
                }
                if(node.right != null)
                {
                    queueNode.Enqueue(node.right);
                }
            }
        }
        return returnList;
    }
}

