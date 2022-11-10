// https://leetcode.com/problems/excel-sheet-column-number/description/
public class Solution 
{
    public int TitleToNumber(string columnTitle) 
    {
        int result = 0;
        for (int idx = 0; idx < columnTitle.Length; idx++)
        {
            result *= 26;
            result += columnTitle[idx] - 'A' + 1;
        }

        return result;
    }
}
