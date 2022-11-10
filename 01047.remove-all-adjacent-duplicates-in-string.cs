// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string 
public class Solution 
{
    public string RemoveDuplicates(string s) 
    {
        StringBuilder buffer = new StringBuilder(s);

        for(int idx = 0; idx < buffer.Length - 1;)
        {
            if (buffer[idx] == buffer[idx + 1])
            {
                buffer.Remove(idx, 2);
                idx = Math.Max(idx - 1, 0);
            }
            else 
            {
                idx++;
            }
        }

        return buffer.ToString();
    }
}
