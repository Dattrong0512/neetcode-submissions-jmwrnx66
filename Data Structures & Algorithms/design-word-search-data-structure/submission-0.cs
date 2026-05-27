public class WordDictionary
{
    public class Node
    {
        public Dictionary<char, Node> Children = new();
        public bool isEnd = false;
    }

    public Node root;

    public WordDictionary()
    {
        root = new Node();
    }

    public void AddWord(string word)
    {
        Node current = root;

        foreach (var item in word)
        {
            if (!current.Children.ContainsKey(item))
            {
                current.Children[item] = new Node();
            }

            current = current.Children[item];
        }

        current.isEnd = true;
    }

    public bool Search(string word)
    {
        return SearchFromNode(word, 0, root);
    }

    private bool SearchFromNode(string word, int index, Node current)
    {
        if (index == word.Length)
        {
            return current.isEnd;
        }

        char ch = word[index];

        if (ch == '.')
        {
            foreach (var child in current.Children.Values)
            {
                if (SearchFromNode(word, index + 1, child))
                {
                    return true;
                }
            }

            return false;
        }

        if (!current.Children.ContainsKey(ch))
        {
            return false;
        }

        return SearchFromNode(word, index + 1, current.Children[ch]);
    }
}