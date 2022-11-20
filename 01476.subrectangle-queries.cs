// https://leetcode.com/problems/subrectangle-queries/description/
public class SubrectangleQueries 
{
    private readonly int[][] _rectangle;
    private readonly List<(int RowX, int RowY, int ColX, int ColY, int Value)> _override;

    public SubrectangleQueries(int[][] rectangle)
    {
        _rectangle = rectangle;
        _override = new List<(int, int, int, int, int)>();
    } 
    
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    {
        _override.Add((row1, row2, col1, col2, newValue));
    }
    
    public int GetValue(int row, int col)
    {
        for(int idx = _override.Count - 1;idx >= 0; idx--)
        {
            (int rowX, int rowY, int colX, int colY, int value) = _override[idx];

            if (Fits(rowX, rowY, row) && Fits(colX, colY, col))
                return value;
        }

        return _rectangle[row][col];
    }

    private static bool Fits(int x, int y, int target) => target >= x && target <= y;
}

/**
 * Your SubrectangleQueries object will be instantiated and called as such:
 * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
 * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
 * int param_2 = obj.GetValue(row,col);
 */
