// https://leetcode.com/problems/zigzag-conversion/description/
public string Convert(string s, int numRows) 
{
    char[] result = new char[s.Length];

    int chunkSize = Math.Max((numRows - 1) * 2, 1);
    int chunkCount = s.Length / chunkSize + (s.Length % chunkSize > 0 ? 1 : 0);

    int resultIdx = 0;

    for(int jdx = 0; jdx < chunkCount; jdx++)
    {
        int chunkPosition = jdx * chunkSize;
        result[resultIdx++] = s[chunkPosition];
    }

    for(int idx = 1; idx < numRows; idx++)
    {
        for(int jdx = 0; jdx < chunkCount; jdx++)
        {
            int chunkPositionX = jdx * chunkSize + idx;
            int chunkPositionY = (jdx + 1) * chunkSize - idx;

            if (chunkPositionX < s.Length)
            {
                result[resultIdx++] = s[chunkPositionX];
            }

            if (chunkPositionX != chunkPositionY && chunkPositionY < s.Length)
            {
                result[resultIdx++] = s[chunkPositionY];
            }
        }
    }

    return new string(result);
}
