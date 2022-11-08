// https://leetcode.com/problems/make-the-string-great/
public class Solution 
{
    public string MakeGood(string s) 
    {
        StringBuilder buffer = new StringBuilder(s);

        int idx = 0;
        while(idx < buffer.Length - 1)
        {
            char x = buffer[idx];
            char y = buffer[idx + 1];

            if (char.ToLower(x) == char.ToLower(y) && x != y)
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