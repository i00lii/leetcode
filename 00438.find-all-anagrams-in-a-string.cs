// https://leetcode.com/problems/find-all-anagrams-in-a-string/description
public class Solution 
{
    public IList<int> FindAnagrams(string s, string p) 
    {   
        List<int> result = new ();
        if (s.Length < p.Length) return result;

        char[] buffer = new char[26];
        foreach(char valueP in p) buffer[valueP - 'a']++;
        
        for (int idx = 0, jdx = -p.Length; idx < s.Length; idx++, jdx++)
        {
            buffer[s[idx] - 'a']--;
            if (jdx >= 0) buffer[s[jdx] - 'a']++;
            if (Empty(buffer)) result.Add(jdx + 1);
        }

        return result;
    }

    private static bool Empty(char[] buffer)
    {
        int sum = 0;
        foreach(int v in buffer) sum += v;
        return sum == 0;
    }
}
