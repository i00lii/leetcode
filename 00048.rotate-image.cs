// https://leetcode.com/problems/rotate-image/description/
public class Solution 
{
    public void Rotate(int[][] matrix) 
    {
        int lastIdx = matrix.Length - 1;
        int half = matrix.Length / 2;
        
        for (int yIdx = 0; yIdx < half; yIdx++)
        {
            for (int xIdx = yIdx; xIdx < lastIdx - yIdx; xIdx++)
            {
                int current = matrix[yIdx][xIdx];

                for(int cornerIdx = 0; cornerIdx < 4; cornerIdx++)
                {
                    int nextXIdx = lastIdx - yIdx;
                    int nextYIdx = xIdx;

                    ref int next = ref matrix[nextYIdx][nextXIdx];
                    int buffer = next;

                    next = current;
                    current = buffer;

                    xIdx = nextXIdx;
                    yIdx = nextYIdx;
                }
            }
        }
    }
}
