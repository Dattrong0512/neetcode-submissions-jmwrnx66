public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> indexStack = new Stack<int>();
        int[] tempArrayLarge = new int[temperatures.Length];
        for(int i = 0; i < temperatures.Length; i++)
        {
            while(indexStack.Count > 0 && (temperatures[i] > temperatures[indexStack.Peek()]))
            {
                int topIndex = indexStack.Pop();
                tempArrayLarge[topIndex] = i - topIndex;
            }
            indexStack.Push(i);
        }

        return tempArrayLarge;
    }
}
