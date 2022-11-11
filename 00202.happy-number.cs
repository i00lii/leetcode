// https://leetcode.com/problems/happy-number/description/
public class Solution 
{
    public bool IsHappy(int n)
    {
        (int slow, int fast) = (n, n);
        do {(slow, fast) = (Next(slow), Next(Next(fast)));} while (slow != fast);
        return slow == 1;
    }

    private static int Next(int number)
    {
        const int basis = 10;
        int result = 0;

        while (number > 0)
        {
            int modulo = number % basis;
            result += modulo * modulo;
            number /= basis;
        }

        return result;
    }
}
