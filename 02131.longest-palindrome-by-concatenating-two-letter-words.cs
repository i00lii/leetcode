// https://leetcode.com/problems/longest-palindrome-by-concatenating-two-letter-words/description/
public class Solution 
{
    public int LongestPalindrome(string[] words) 
    {
        Dictionary<(char, char), int> buffer = new();
        
        foreach (string word in words)
        {
            (char, char) key = (word[0], word[1]);
            
            
            if (buffer.ContainsKey(key))
            {
                buffer[key]++;
            }
            else 
            {
                buffer[key] = 1;
            }
        }
        
        bool extraPiece = false;
        int result = 0;
        
        foreach (KeyValuePair<(char, char), int> value in buffer)
        {
            ((char X, char Y) key, int count) = value;
            
            if (key.X != key.Y)
            {
                if (buffer.TryGetValue((key.Y, key.X), out int backwardCount))
                {   
                    result += Math.Min(count, backwardCount) * 4;
                    buffer.Remove((key.Y, key.X));
                }
            }
            else
            {
                result += count / 2 * 4;
                
                if (!extraPiece && count % 2 != 0)
                {
                    extraPiece = true;
                    result += 2;
                }
            }
        }

        return result;
    }
}
