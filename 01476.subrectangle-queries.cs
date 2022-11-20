// https://leetcode.com/problems/subrectangle-queries/description/
public class SubrectangleQueries 
{
    private readonly int[][] _rectangle;
    public SubrectangleQueries(int[][] rectangle) => _rectangle = rectangle;
    
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    {
        for (int row = row1; row <= row2; row++)
        {
            int[] rowValues = _rectangle[row];
            Array.Fill(rowValues, newValue, col1, col2 - col1 + 1);
        }
    }
    
    public int GetValue(int row, int col) => _rectangle[row][col];
}

/**
 * Your SubrectangleQueries object will be instantiated and called as such:
 * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
 * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
 * int param_2 = obj.GetValue(row,col);
 */

