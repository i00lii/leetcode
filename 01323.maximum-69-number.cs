// maximum-69-number
public class Solution 
{
    public int Maximum69Number(int num) 
    {
        int buffer = num;
        
        int multiplier = 1;
        int max = num;
        
        while (buffer > 0)
        {
            if (buffer % 10 == 6)
            {
                max = num + 3 * multiplier;
            }

            buffer /= 10;
            multiplier *= 10;
        }

        return max;
    }
}
