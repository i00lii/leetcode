// https://leetcode.com/problems/count-and-say/description/ 
public class Solution 
{
    private readonly string[] _buffer;

    public Solution()
    {
        _buffer = new string[30];
        _buffer[0] = "1";
    }

    public string CountAndSay(int n)
    {

        if (_buffer[n - 1] is {} buffered)
        {
            return buffered;
        }

        for(int x = n - 2; x >= 0; x--)
        {
            if (_buffer[x] != default)
            {
                for(int y = x + 1; y < n; y++)
                {
                    _buffer[y] = Next(_buffer[y - 1]);
                }
            }
        }

        return _buffer[n - 1];
    }

    private static string Next(string value)
    {
        char currentGroup = default;
        int currentCount = default;
        StringBuilder result = new StringBuilder();

        for (int idx = 0; idx < value.Length; idx++)
        {
            char currentValue = value[idx];
            if (idx == 0)
            {
                currentGroup = currentValue;
                currentCount = 1;
            }
            else if (currentValue == currentGroup)
            {
                currentCount++;
            }
            else
            {
                result.Append(currentCount);
                result.Append(currentGroup);

                currentGroup = currentValue;
                currentCount = 1;
            }
        }

        result.Append(currentCount);
        result.Append(currentGroup);
        return result.ToString();
    }
}
