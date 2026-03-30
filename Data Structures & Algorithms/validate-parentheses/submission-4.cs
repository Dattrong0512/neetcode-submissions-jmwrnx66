public class Solution {
    public bool IsValid(string s) {
        Stack<char> stackString = new Stack<char>();
        Dictionary<char,char> lookupSign = new Dictionary<char,char>()
        {
            { ']', '[' },
            { '}', '{' },
            { '>', '<' },
            { ')', '(' }
        };
        foreach(char c in s)
        {
            if(lookupSign.ContainsKey(c))
            {
                if(stackString.Count == 0 || stackString.Peek() != lookupSign[c])
                {
                    return false;
                }
                else
                {
                    stackString.Pop();
                }
            }
            else
            {
                stackString.Push(c);
            }
        }
        if(stackString.Count > 0) return false;
        return true;
    }
}
