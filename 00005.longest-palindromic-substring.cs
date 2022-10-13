// https://leetcode.com/problems/longest-palindromic-substring/description/
public string LongestPalindrome(string s) 
{   
    List<Palindrome> buffer = new List<Palindrome>(s.Length);
    Palindrome result = default;

    for (int idx = 0; idx < s.Length; idx++)
    {
        buffer.Add(new Palindrome(idx, idx));

        if (idx < s.Length - 1 && s[idx] == s[idx + 1])
        {    
            buffer.Add(new Palindrome(idx, idx + 1));   
        }
    }

    result = buffer[0];


    while (buffer.Count > 0)
    {
        for (int idx = 0; idx < buffer.Count;)
        {
            Palindrome current = buffer[idx];

            int x = current.X - 1;
            int y = current.Y + 1;

            if (x < 0 || y >= s.Length || (s[x] != s[y]))
            {
                buffer.RemoveAt(idx);

                if (current.Y - current.X > result.Y - result.X)
                {
                    result = current;
                }
            }
            else
            {
                buffer[idx] = new Palindrome(x, y);
                idx++;
            }
        }
    }

    return s.Substring(result.X, result.Y - result.X + 1);
}

private readonly struct Palindrome
{
    public readonly int X;
    public readonly int Y;
    public Palindrome(int x, int y) =>(X, Y) = (x, y);        
}
