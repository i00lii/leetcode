// https://leetcode.com/problems/valid-parentheses/description/
public class Solution 
{
    public bool IsValid(string s) 
    {
        Stack<char> buffer = new Stack<char>();
        
        foreach(char value in s)
        {
            switch(value)
            {
                case '(':
                case '{':
                case '[':
                    buffer.Push(value);
                    break;
                    
                case ')':                    
                    if (buffer.Count == 0 || buffer.Pop() != '(')
                        return false;

                    break;
                case ']':                    
                    if (buffer.Count == 0 || buffer.Pop() != '[')
                        return false;

                    break;
                case '}':
                    if (buffer.Count == 0 || buffer.Pop() != '{')
                        return false;

                    break;
                
                default:
                    return false;
            }
        }
        
        return buffer.Count == 0;
    }
}
