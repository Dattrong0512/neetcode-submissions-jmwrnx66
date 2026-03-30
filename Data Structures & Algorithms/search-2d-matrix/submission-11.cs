public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int n = matrix.Count();
        int m = matrix[0].Count();
        int left = 0;
        int right = m * n - 1;
        int current; 
        while(left <= right)
        {
            int middle = left + ((right - left) / 2);
            current = matrix[middle / m][middle % m];
            if(current == target)
            {
                return true;
            }
            else if(target > current)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        
        return false;
    }   
}