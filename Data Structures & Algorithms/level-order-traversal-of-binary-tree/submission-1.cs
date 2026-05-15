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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> returnList = new List<List<int>>();
        if(root == null)
        {
            return returnList;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>(new[] {root});
        while(queue.Count > 0)
        {
            int size = queue.Count;
            List<int> listReturn = new List<int>();
            for(int i = 0; i < size; i++)
            {
                TreeNode node = queue.Dequeue();
                listReturn.Add(node.val);
                if(node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if(node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            returnList.Add(listReturn);
        }
        return returnList;
    }
}
