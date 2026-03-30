public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int n = matrix.Count();
        int m = matrix[0].Count();
        int[] flatMatrix = new int[m * n];
        int index = 0;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                flatMatrix[index] = matrix[i][j];
                index++;
            }
        }

        return BinarySearch(0, m * n - 1 , flatMatrix, target);
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