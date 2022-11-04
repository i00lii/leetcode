// https://leetcode.com/problems/reverse-vowels-of-a-string/description/
public class Solution 
{
    public string ReverseVowels(string s) 
    {
        if (string.IsNullOrEmpty(s))
            return s;

        char[] buffer = s.ToCharArray();

        int begin = 0;
        int end = buffer.Length - 1;

        while (true)
        {
            while(!IsVovel(s[begin]) && begin < end)
            {
                begin++;
            }

            while(!IsVovel(s[end]) && begin < end)
            {
                end--;
            }

            if (begin >= end)
                break;

            char temp = buffer[begin];
            buffer[begin] = buffer[end];
            buffer[end] = temp;

            begin++;
            end--;
        }

        return new string(buffer);
    }

    private static bool IsVovel(char value)
        => value switch
        {
            'a' or 'e' or 'i' or 'u' or 'o'=> true,
            'A' or 'E' or 'I' or 'U' or 'O'=> true,
            _ => default
        };
}