// https://leetcode.com/problems/string-to-integer-atoi/description/
public int MyAtoi(string s)
{
    int result = 0;
    int multiplier = 1;
    ReadOnlySpan<char> span = s.AsSpan().Trim();

    if (span.IsEmpty)
    {
        return result;
    }

    if (span[0] is char first && (first == '+' || first == '-'))
    {
        span = span[1..];
        multiplier = first == '-' ? -1 : 1;
    }

    int length = 0;
    while(length < span.Length && span[length] is char x && char.IsDigit(x))
    {
        length++;
    }

    if(length > 0)
    {
        span = span[0..length];
        if (int.TryParse(span, out int value))
        {
            result = value * multiplier;
        }
        else
        {
            result = multiplier > 0 ? int.MaxValue : int.MinValue;
        }            
    }

    return result;
}
