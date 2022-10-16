// https://leetcode.com/problems/longest-common-prefix/description/
public string LongestCommonPrefix(string[] strs) 
{
    for(int idx = 0;;idx++)
    {
        if (idx >= strs[0].Length)
            return strs[0].Substring(0, idx);

        char current = strs[0][idx];

        for(int jdx = 1; jdx < strs.Length; jdx++)
        {
            string currentString = strs[jdx];

            if (idx >= currentString.Length || currentString[idx] != current)
            {
                return strs[0].Substring(0, idx);
            }
        }
    }
}
