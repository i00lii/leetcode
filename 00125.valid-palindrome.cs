// https://leetcode.com/problems/valid-palindrome/description/
public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        int left = Move(0, s, +1);
        int right = Move(s.Length - 1, s, -1);

        while (right > left)
        {
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }

            left = Move(left + 1, s, +1);
            right = Move(right - 1, s, -1);
        }

        return true;
    }

    private static int Move(int x, string s, int shift)
    {
        do
        {
            char value = s[x];
            if (char.IsLetter(value) || char.IsDigit(value))
                return x;

            x += shift;
        }
        while(x < s.Length && x >= 0);

        return x;
    }
}
