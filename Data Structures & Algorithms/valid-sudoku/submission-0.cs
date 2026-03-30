public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool [,] rows = new bool[9,9];
        bool [,] cols = new bool[9,9];
        bool [,] area = new bool[9,9];

        for(int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] == '.') continue;
                int num = board[i][j] - '1';
                int index = (i/3)*3 + (j/3);

                if(rows[i,num] || cols[j,num] || area[index, num])
                {
                    return false;
                }


                rows[i,num] = true;
                cols[j,num] = true; 
                area[index, num] = true;
            }   
        }

        return true;
    }
}
