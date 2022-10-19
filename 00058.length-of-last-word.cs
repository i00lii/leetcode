// https://leetcode.com/problems/length-of-last-word/description/
public int LengthOfLastWord(string s) 
{
    int lastIdx = -1;
    int beforeFirstIdx = -1;

    for (int idx = s.Length - 1; idx >= 0; idx--)
    {
        bool isWhitespace = char.IsWhiteSpace(s[idx]);

        if (lastIdx == -1)
        {
            if (!isWhitespace)
            {
                lastIdx = idx;    
            }
        }
        else 
        {
            if (isWhitespace)
            {
                beforeFirstIdx = idx;
                break;
            }
        }
    }

    return lastIdx - beforeFirstIdx;
}
