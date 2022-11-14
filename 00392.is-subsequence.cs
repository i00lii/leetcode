// https://leetcode.com/problems/is-subsequence/description
public class Solution 
{
    public bool IsSubsequence(string s, string t) 
    {
        int sIdx = 0;
        int tIdx = 0;

        while (sIdx < s.Length && tIdx < t.Length)
        {
            if (s[sIdx] == t[tIdx]) sIdx++;
            tIdx++;
        }

        return sIdx == s.Length;
    }
}
