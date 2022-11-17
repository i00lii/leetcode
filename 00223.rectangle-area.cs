// https://leetcode.com/problems/rectangle-area/description/
public class Solution 
{
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) 
    {
        int s1 = (ax2 - ax1) * (ay2 - ay1);
        int s2 = (bx2 - bx1) * (by2 - by1);

        int overlappedX = Math.Max(Math.Min(ax2, bx2) - Math.Max(ax1, bx1), 0);
        int overlappedY = Math.Max(Math.Min(ay2, by2) - Math.Max(ay1, by1), 0);
        int s3 = overlappedX * overlappedY;

        return s1 + s2 - s3;
    }
}
