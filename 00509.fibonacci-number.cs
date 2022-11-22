// https://leetcode.com/problems/fibonacci-number/description
public class Solution 
{
    private readonly int[] _lookup;

    public Solution()
    {
        _lookup = new int[31];
        _lookup[1] = 1;

        for (int idx = 2; idx < _lookup.Length; idx++)
        {
            _lookup[idx] = _lookup[idx - 1] + _lookup[idx - 2];
        }
    }

    public int Fib(int n) => _lookup[n];
}
