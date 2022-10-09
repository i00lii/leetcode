// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
public int LengthOfLongestSubstring(string s)    
{
    short[] charPositions = new short[128];
    charPositions.AsSpan().Fill(-1);
        
    int start = 0;
    int result = 0;
    for (short i = 0; i < s.Length; ++i)
    {
        ref short position = ref charPositions[s[i]];
        start = Math.Max(start, position + 1);
        position = i;
        result = Math.Max(result, i - start + 1);
    }
    return result;
}
