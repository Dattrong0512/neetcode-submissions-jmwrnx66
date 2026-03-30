public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> storageNumber = new Stack<int>();
        HashSet<string> signs = new HashSet<string>(){"+", "-", "*", "/"};
        for(int i = 0; i < tokens.Length; i++)
        {
            if(signs.Contains(tokens[i]))
            {
                int b = storageNumber.Pop();
                int a = storageNumber.Pop();
                switch(tokens[i])
                {
                    case "/":
                        storageNumber.Push(a/b);
                        break;
                    case "+":
                        storageNumber.Push(a+b);
                        break;
                    case "-":
                        storageNumber.Push(a-b);
                        break;
                    case "*":
                        storageNumber.Push(a*b);
                        break;
                }
            }
            else
            {
                storageNumber.Push(Convert.ToInt32(tokens[i]));
            }
        }

        return  storageNumber.Pop();
    }
}
