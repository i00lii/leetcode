// https://leetcode.com/problems/number-of-1-bits/description/
public class Solution 
{
    public int HammingWeight(uint n) 
    {
        uint result = 0;

        while (n > 0)
        {
            n &= n-1;
            result++;
        }

        return (int)result;
    }
}
