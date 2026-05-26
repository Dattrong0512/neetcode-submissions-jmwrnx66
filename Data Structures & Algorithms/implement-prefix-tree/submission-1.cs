public class PrefixTree {
    public class TreeNode
    {
        public Dictionary<char, TreeNode> Children = new();
        public bool isEnd = false;  
    }

    public TreeNode root;
    public PrefixTree() {
        root = new TreeNode();
    }
    
    public void Insert(string word)
    {
        TreeNode current = root;
        foreach(var item in word)
        {
            if(!current.Children.ContainsKey(item))
            {
                current.Children[item] = new TreeNode();
            }
            current = current.Children[item];
        }
        current.isEnd = true;
    }
    
    public bool Search(string word) {
        TreeNode result = Find(word);
        return result != null && result.isEnd == true;
    }
    
    public bool StartsWith(string prefix) {
        return Find(prefix) != null;
    }

    public TreeNode Find(string word)
    {
        TreeNode current = root;
        foreach(var item in word)
        {
            if(!current.Children.ContainsKey(item))
            {
                return null;
            }
            current = current.Children[item];
        }
        return current;
    }
}
