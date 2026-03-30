public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int n = matrix.Count();
        int m = matrix[0].Count();
        for(int i = 0; i < n; i++)
        {
            if(BinarySearch(0, m - 1 , matrix[i], target))
            {
                return true;
            } 
        }
        return false;
    } 

    public bool BinarySearch(int leftIndex, int rightIndex, int[] array, int target)
    {
        if(leftIndex > rightIndex)
        {
            return false;
        }

        int middleIndex = leftIndex + ((rightIndex - leftIndex) / 2);
        if(array[middleIndex] == target)
        {
            return true;
        }
        else if(target < array[middleIndex])
        {
            return BinarySearch(leftIndex, middleIndex - 1, array, target);
        }
        else
        {
            return BinarySearch(middleIndex + 1, rightIndex, array, target);
        }
    }
}