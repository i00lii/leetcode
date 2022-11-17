// https://leetcode.com/problems/merge-intervals/description/
public class Solution 
{
    public int[][] Merge(int[][] intervals) 
    {
        Array.Sort(intervals, new IntervalComparer());
        List<int[]> result = new List<int[]>(intervals);

        for (int idx = 0; idx < result.Count - 1; idx++)
        {
            int[] y = result[idx + 1];
            int[] x = result[idx];

            if (Overlapped(x, y))
            {
                Squash(y, x);
                result.RemoveAt(idx--);
            }
        }

        return result.ToArray();
    }

    private static bool Overlapped(int[] x, int[] y)
        => (Math.Min(x[1], y[1]) - Math.Max(x[0], y[0])) >= 0;

    private static void Squash(int[] x, int[] y)
    {
        x[0] = Math.Min(x[0], y[0]);
        x[1] = Math.Max(x[1], y[1]);
    }

    private class IntervalComparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y) => x[0] - y[0];
    }
}
