// https://leetcode.com/problems/roman-to-integer/description/
public int RomanToInt(string s) 
{
    int result = 0;
    int previousValue = 0;

    for(int idx = s.Length -1; idx >= 0; idx--)
    {
        int currentValue = s[idx] switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,  
            _ => default    
        };

        if (currentValue < previousValue)
        {
            result -= currentValue;
        }
        else
        {
            result += currentValue;
        }

        previousValue = currentValue;
    }

    return result;
}
