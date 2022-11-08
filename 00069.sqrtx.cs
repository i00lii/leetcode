// https://leetcode.com/problems/sqrtx/submissions/839739978/
public class Solution 
{
    public int MySqrt(int x)
    {
        if (x <= 1)
            return x;

        int left = 1;
        int right = Math.Min(x / 2, 46340);

        while (right >= left)
        {
            int middle = (left + right) / 2;
            int target = middle * middle;
            
            if (target < x) left = middle + 1; 
            else if (target > x) right = middle - 1; 
            else return middle;
        }

        return right;
    }
}
