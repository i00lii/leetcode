// https://leetcode.com/problems/valid-anagram/description/
public class Solution 
{
    private static readonly int[] _counter = new int['z' - 'a' + 1];

    public bool IsAnagram(string s, string t)
    {   
        if (s.Length != t.Length) return false;
        Array.Fill(_counter, 0);
        
        foreach (char x in s)
        {
            _counter[x - 'a']++;
        }

        int balance = s.Length;
        foreach (char x in t)
        {
            ref int c = ref _counter[x - 'a'];

            if (c > 0)
            {
                balance--;
                c--;
            }
            else 
            {
                return false;
            }
        }

        return balance == 0;
    }
}
