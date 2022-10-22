// https://leetcode.com/problems/minimum-window-substring/description/
public class Solution 
{
    public string MinWindow(string s, string t) 
    {
        Dictionary<char, Counter> buffer = new Dictionary<char, Counter>();
        Queue<int> positions = new Queue<int>();
        
        int totalFound = 0;
        int resultIdx = 0;
        int resultLength = 0;
        
        foreach(char item in t)
        {
            Counter counter;
            if (buffer.ContainsKey(item))
            {
                counter = buffer[item];
            }
            else 
            {
                counter = new Counter();
                buffer[item] = counter; 
            }
            
            counter.TotalRequired++;
        }

        for(int endIdx = 0; endIdx < s.Length; endIdx++)
        { 
            if (buffer.TryGetValue(s[endIdx], out Counter currentEnd))
            {                
                if (currentEnd.TotalFound < currentEnd.TotalRequired)
                {
                    totalFound++;
                }
                
                positions.Enqueue(endIdx);
                currentEnd.TotalFound++;
            }
            
            while (totalFound == t.Length)
            {
                int beginIdx = positions.Dequeue();
                Counter currentBegin = buffer[s[beginIdx]];

                if (currentBegin.TotalFound <= currentBegin.TotalRequired)
                {
                    totalFound--;
                    
                    int length = endIdx - beginIdx + 1;
                    if (resultLength == 0 || length < resultLength)
                    {
                        resultLength = length;
                        resultIdx = beginIdx;
                    }
                }

                currentBegin.TotalFound--;
            }
        }
        return s.Substring(resultIdx, resultLength);
    }
    
    private sealed class Counter
    {
        public int TotalRequired;
        public int TotalFound;
    }
}
