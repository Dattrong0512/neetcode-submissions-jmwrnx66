public class Solution {
    public int LargestRectangleArea(int[] heights) 
    {
        Stack<int> stackHeight= new Stack<int>();
        int MaxAreaRectangle = 0;
        int maxHeight;
        for(int i = 0; i <= heights.Length; i++)
        {
            maxHeight = (i == heights.Length) ? 0 : heights[i];
            while(stackHeight.Count > 0 && maxHeight < heights[stackHeight.Peek()])
            {
                int height = heights[stackHeight.Pop()];
                int width;
                if(stackHeight.Count == 0)
                {
                    width = i;
                }
                else
                {
                    width = i - stackHeight.Peek() - 1;
                }
                MaxAreaRectangle = Math.Max(height*width, MaxAreaRectangle);
            }

            stackHeight.Push(i);
        }
    
        return MaxAreaRectangle;
    }
}
