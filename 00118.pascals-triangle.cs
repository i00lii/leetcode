// https://leetcode.com/problems/pascals-triangle/description/
public class Solution 
{
    public IList<IList<int>> Generate(int numRows) 
    {
        List<IList<int>> result = new List<IList<int>>();

        int[] old = new int[]{1};
        result.Add(old);

        for (int size = 2; size <= numRows; size++)
        {            
            int x = 0;
            int y = size - 1;

            int[] current = new int[size];
            current[x++] = 1;
            current[y--] = 1;

            while(y >= x)
            {
                int pascal = old[x - 1] + old[x];
                current[x++] = pascal;
                current[y--] = pascal;
            }

            result.Add(current);
            old = current;
        }

        return result;
    }
}
