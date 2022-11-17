// https://leetcode.com/problems/longest-palindrome/description/
public class Solution
{
    public int LongestPalindrome(string s)
    {
        HashSet<char> buffer = new();
        int result = 0;

        foreach (char value in s)
        {
            if (!buffer.Contains(value))
            {
                buffer.Add(value);
            }
            else 
            {
                buffer.Remove(value);
                result += 2;
            }
        }

        if (buffer.Count > 0)
        {
            result += 1;
        }

        return result;
    }
}
