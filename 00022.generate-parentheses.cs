// https://leetcode.com/problems/generate-parentheses/description/
public class Solution 
{
    public IList<string> GenerateParenthesis(int n) 
    {
        List<string> result = new();
        Recursion(0, 0, 0, n, new StringBuilder(n * 2), result);
        return result;

        static void Recursion(int opened, int closed, int bufferIdx, int max, StringBuilder buffer, List<string> result)
        {
            if (buffer.Length == max * 2)
            {
                result.Add(buffer.ToString());
                return;
            }

            if(opened < max)
            {
                buffer.Remove(bufferIdx, buffer.Length - bufferIdx);
                buffer.Append('(');
                Recursion(opened + 1, closed, bufferIdx + 1, max, buffer, result);
            }

            if (opened > closed)
            {
                buffer.Remove(bufferIdx, buffer.Length - bufferIdx);
                buffer.Append(')');                
                Recursion(opened, closed + 1, bufferIdx + 1, max, buffer, result);
            }
        }
    }
}
