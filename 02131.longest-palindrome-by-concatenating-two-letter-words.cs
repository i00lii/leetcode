// https://leetcode.com/problems/longest-palindrome-by-concatenating-two-letter-words/description/
public class Solution 
{
    public int LongestPalindrome(string[] words) 
    {
        Dictionary<(char, char), Context> buffer = new();
        
        foreach (string word in words)
        {
            char x = word[0];
            char y = word[1];
            
            if (x < y)
            {
                if (buffer.TryGetValue((x,y), out Context value))
                {
                    value.ForwardCount++;
                }
                else 
                {    
                    buffer[(x, y)] = new Context(1, 0, false);
                }
            }
            else if (x > y)
            {
                if (buffer.TryGetValue((y, x), out Context value))
                {
                    value.BackwardCount++;
                }
                else 
                {    
                    buffer[(y, x)] = new Context(0, 1, false);
                }
            }
            else 
            {
                if (buffer.TryGetValue((x, y), out Context value))
                {
                    if (value.ForwardCount > value.BackwardCount)
                    {                        
                        value.BackwardCount++;
                    }
                    else
                    {
                        value.ForwardCount++;
                    }
                }
                else 
                {    
                    buffer[(x, y)] = new Context(1, 0, true);
                }
            }
        }
        
        bool isExtraPiece = false;
        int pairedPiecesCount = 0;
        
        foreach (Context value in buffer.Values)
        {
            if (!isExtraPiece && value.IsSameLetters && value.ForwardCount != value.BackwardCount)
            {
                isExtraPiece = true;
            }
            
            pairedPiecesCount += Math.Min(value.ForwardCount, value.BackwardCount);
        }
        
        return (pairedPiecesCount * 4) + (isExtraPiece ? 2 : 0);
    }
    
    private sealed class Context
    {
        public int ForwardCount;
        public int BackwardCount;
        public bool IsSameLetters { get; }
        
        public Context(int forwardCount, int backwardCount, bool isSameLetters) => (ForwardCount, BackwardCount, IsSameLetters) = (forwardCount, backwardCount, isSameLetters);
    }
}
