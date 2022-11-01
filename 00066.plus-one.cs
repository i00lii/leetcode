// https://leetcode.com/problems/plus-one/description/
public class Solution 
{
    public int[] PlusOne(int[] digits)
    {
        int temp = 1;
        Add(ref digits[digits.Length - 1], ref temp);
        
        for(int idx = digits.Length - 2; idx >= 0 && temp > 0; idx--)
        {
            Add(ref digits[idx], ref temp);
        }
        
        if (temp > 0)
        {
            int[] result = new int[digits.Length + 1];
            result[0] = temp;
            Array.Copy(digits, 0, result, 1, digits.Length);
            
            return result;
        }
        
       return digits;
        
    }
    
    private static void Add(ref int x, ref int y)
    {
        x = x + y;
        y = x / 10;
        x = x % 10;
    }
}
