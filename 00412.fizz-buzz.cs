// https://leetcode.com/problems/fizz-buzz/description/
public class Solution 
{
    public IList<string> FizzBuzz(int n) 
    {
        List<string> result = new (n);

        for (int i = 1; i <= n; i++)
        {
            string r = string.Empty;
            
            if (i % 3 == 0) r += "Fizz";
            if (i % 5 == 0) r += "Buzz";

            result.Add(string.IsNullOrEmpty(r) ? i.ToString() : r);
        }

        return result;
    }
}
