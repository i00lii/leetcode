// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/
//
// The solution is not optimal.
// The faster solution in to use Z-algorithm with O(n + m) time complexity 
// but also O(n + m) additional space required.
public class Solution 
{
    public int StrStr(string haystack, string needle) 
    {
        for (int idx = 0; idx <= haystack.Length - needle.Length; idx++)
        {
            if (AreEquals(haystack, idx, needle) return idx;
        }

        return -1;
    }

    private static bool AreEquals(string haystack, int idx, string needle)
    {
        for(int jdx = 0; jdx < needle.Length; jdx++)
        {
            if (haystack[idx + jdx] != needle[jdx])
                return false;
        }

        return true;
    }
}
