// https://leetcode.com/problems/divide-two-integers/description/
public class Solution 
{
    public int Divide(int dividend, int divisor) 
    {        
        if (dividend == 0)
            return 0;
        
        if (divisor == 1)
            return dividend;
        
        if (divisor == -1)
            return dividend == int.MinValue ? int.MaxValue : -dividend;
        
        bool isPositive = dividend < 0 == divisor < 0;
        long buffer = Math.Abs((long)dividend);
        long d = Math.Abs((long)divisor);
        int result = 0;
        
        while (buffer >= d)
        {
            int power = 0;

            while(buffer > (d << power + 1))
            {
                power++;
            }

            Console.WriteLine((buffer, result));
            result += 1 << power;
            buffer -= d << power;
        }
        
        return isPositive ? result : -result;
    }
}
