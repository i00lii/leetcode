// https://leetcode.com/problems/integer-to-roman/description/
public class Solution 
{
    private static string[] _letters = new string[]
    {
        "IVX",
        "XLC",
        "CDM",
        "M"
    };
    
    public string IntToRoman(int num) 
    {
        int tempateIdx = 0;
        StringBuilder builder = new StringBuilder(16);   
        
        while (num > 0)
        {
            string template = _letters[tempateIdx++];
            
            int digit = num % 10;
            
            if (digit >= 1 && digit <= 3)
            {
                for (int idx = 0; idx < digit; idx++)
                {
                    builder.Insert(0, template[0]);
                }
            }
            else if (digit == 4)
            {
                builder.Insert(0, template[1]);
                builder.Insert(0, template[0]);
            }
            else if (digit >= 5 && digit <= 8)
            {
                for (int idx = 0; idx < digit - 5; idx++)
                {
                    builder.Insert(0, template[0]);
                }
                
                builder.Insert(0, template[1]);
            }
            else if (digit == 9)
            {
                builder.Insert(0, template[2]);
                builder.Insert(0, template[0]);
            }
            
            
            num /= 10;
        }
        
        return builder.ToString();
    }
}
