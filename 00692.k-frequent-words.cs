// https://leetcode.com/problems/top-k-frequent-words/description/
// beware power of the linq
public IList<string> TopKFrequent(string[] words, int k) 
    => words
    .GroupBy(item => item)
    .Select(item => (Count: item.Count(), Value: item.Key))
    .OrderByDescending(item => item.Count)
    .ThenBy(item => item.Value)
    .Take(k)
    .Select(item => item.Value)
    .ToArray();
