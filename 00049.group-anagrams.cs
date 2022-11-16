// https://leetcode.com/problems/group-anagrams/description/
public class Solution 
{
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string, List<string>> buffer = new();

        foreach (string value in strs)
        {
            char[] allocation = value.ToCharArray();
            Array.Sort(allocation);
            string key = new string(allocation);

            if (buffer.TryGetValue(key, out List<string> anagrams))
            {
                anagrams.Add(value);
            }
            else 
            {
                buffer.Add(key, new List<string>(){value});
            }
        }

        return buffer.Values.ToList<IList<string>>();
    }
}
