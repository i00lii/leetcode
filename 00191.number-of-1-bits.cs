// https://leetcode.com/problems/number-of-1-bits/description/
public class Solution 
{
    public int HammingWeight(uint n) 
    {
        const int size = sizeof(uint) * 8;
        
        uint result = 0;
        for (int idx = 0; idx < size; idx++)
        {
            result += (n >> idx) & 1;
        }

        return (int)result;
    }
}
