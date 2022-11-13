// https://leetcode.com/problems/reverse-words-in-a-string/description/
public class Solution 
{
    public string ReverseWords(string s) 
    {
        char[] buffer = s.ToCharArray();
        Array.Reverse(buffer);
        
        int wordCount = 0;
        int wordTotal = 0;
        
        for (int offsetIdx = 0; offsetIdx < buffer.Length; offsetIdx++)
        {
            int wordBeginIdx = FindBegin(offsetIdx, buffer);

            if (wordBeginIdx >= buffer.Length)
                break;

            int wordEndIdx = FindEnd(wordBeginIdx, buffer);

            Swap(buffer, offsetIdx, wordEndIdx);
            
            wordCount++;
            int size = (wordEndIdx - wordBeginIdx) + 1;
            wordTotal += size;
            offsetIdx += size;
        }

        return new string(buffer, 0, wordCount + wordTotal -1);
    }

    private static void Swap(char[] buffer, int from, int to)
    {
        while (to > from)
        {
            char temp = buffer[from];
            buffer[from++] = buffer[to];
            buffer[to--] = temp;
        }
    } 

    private static int FindBegin(int idx, char[] buffer)
    {
        for (;idx < buffer.Length; idx++)
        {
            char current = buffer[idx];

            if (char.IsLetter(current) || char.IsDigit(current))
            {
                return idx;
            }
        }

        return idx;
    }

    private static int FindEnd(int idx, char[] buffer)
    {
        for(;idx < buffer.Length; idx++)
        {
            if (char.IsWhiteSpace(buffer[idx]))
            {
                return idx - 1;
            }
        }

        return idx - 1;
    }
}
