// https://leetcode.com/problems/reshape-the-matrix/description
public class Solution 
{
    public int[][] MatrixReshape(int[][] mat, int r, int c) 
    {
        int sizeR = mat[0].Length;
        int sizeC = mat.Length;
        if (sizeR * sizeC != r * c) return mat;

        int[][] result = Enumerable.Range(0, r).Select(_ => new int[c]).ToArray();
        IEnumerator<(int, int)> original = Yield(sizeR, sizeC).GetEnumerator();
        IEnumerator<(int, int)> reshaped = Yield(c, r).GetEnumerator();

        while (original.MoveNext() && reshaped.MoveNext())
        {
            (int originalR, int originalC) = original.Current;
            (int reshapedR, int reshapedC) = reshaped.Current;
            result[reshapedC][reshapedR] = mat[originalC][originalR];
        }

        return result;
    }

    private static IEnumerable<(int, int)> Yield(int sizeR, int sizeC)
    {
        for (int c = 0; c < sizeC; c++)
        {
            for (int r = 0; r < sizeR; r++)
            {
                yield return (r, c);
            }
        }
    }
}
