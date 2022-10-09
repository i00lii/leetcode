// https://leetcode.com/problems/palindrome-number/description/
public bool IsPalindrome(int x)
{
    if (x < 0)
        return false;

    if (x == 0)
        return true;

    int lastIdx = (int)Math.Floor(Math.Log10(x) + 1) - 1;
    int head = x;
    int tail = x;

    for(int idx = 0; idx <= lastIdx / 2; idx++)
    {    
        int headMultiplier = (int)Math.Pow(10, lastIdx - idx);
        int headDigit = (int)Math.Floor((double)head / headMultiplier);

        int tailDigit = tail % 10;

        head = head - headMultiplier * (int)Math.Floor((double)head / headMultiplier);
        tail /= 10;

        if (headDigit != tailDigit)
            return false;
    }

    return true;
}
