// https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/description/
public class Solution 
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        IEnumerator<char> x = Yield(word1).GetEnumerator();
        IEnumerator<char> y = Yield(word2).GetEnumerator();
        
        bool xMoved = false;
        bool yMoved = false;
        
        while((xMoved = x.MoveNext()) & (yMoved = y.MoveNext()))
        {
            if (x.Current != y.Current)
            {
                return false;
            }
        }
        
        return xMoved == yMoved;
    }
    
    private static IEnumerable<char> Yield(string[] items)
    {
        foreach (string item in items)
        {
            foreach (char value in item)
            {
                yield return value;
            }
        }
    }
}
