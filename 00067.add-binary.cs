// https://leetcode.com/problems/add-binary/description/
public class Solution 
{
    private const char zero = '0';
    private const char one = '1';
        
    public string AddBinary(string a, string b) 
    {   
        int aIdx = a.Length - 1;
        int bIdx = b.Length - 1;
        int overflow = 0;
        
        StringBuilder buffer = new StringBuilder(Math.Max(aIdx, bIdx) + 2);

        for (;aIdx >= 0 && bIdx >= 0; aIdx--, bIdx--)
            Insert(buffer, a[aIdx] - zero, b[bIdx] - zero, ref overflow);

        for (;aIdx >=0; aIdx--)
            Insert(buffer, a[aIdx] - zero, 0, ref overflow);
        
        for (;bIdx >=0; bIdx--)
            Insert(buffer, b[bIdx] - zero, 0, ref overflow);

        if (overflow > 0)
            buffer.Insert(0, one);

        return buffer.ToString();
    }

    private static void Insert(StringBuilder buffer, int x, int y, ref int overflow)
    {
        int sum = x + y + overflow;
        overflow = sum / 2;
        buffer.Insert(0, (char)(zero + sum % 2));
    }
}
