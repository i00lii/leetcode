// https://leetcode.com/problems/excel-sheet-column-title/description/
public class Solution 
{
    public string ConvertToTitle(int columnNumber) 
    {
        const int size = 26;
        StringBuilder builder = new StringBuilder();
        while (columnNumber > 0)
        {
            int modulo = (columnNumber - 1) % size;
            builder.Insert(0, (char)('A' + modulo));
            columnNumber = (columnNumber - modulo) / 26;
        }

        return builder.ToString();
    }
}
