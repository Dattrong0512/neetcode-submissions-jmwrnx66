public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int left = 0;
        int right = matrix[0].Length - 1;
        while(left < matrix.Length && right >= 0)
        {
            int currentValue = matrix[left][right];
            if(target == currentValue)
            {
                return true;
            }
            if(target > currentValue)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return false;
    }   
}