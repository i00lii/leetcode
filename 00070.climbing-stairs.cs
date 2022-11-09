// https://leetcode.com/problems/climbing-stairs/description/
public class Solution 
{
    private static readonly int[] _buffer = new int[46];

    static Solution()
    {
        _buffer[1] = 1;
        _buffer[2] = 2;

        for (int idx = 3; idx < _buffer.Length; idx++)
        {
            _buffer[idx] = _buffer[idx - 1] + _buffer[idx - 2];
        }
    }

    public int ClimbStairs(int n) => _buffer[n];
}
