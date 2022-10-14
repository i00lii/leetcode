// https://leetcode.com/problems/container-with-most-water/description/
public int MaxArea(int[] height) 
{
    int x = 0;
    int y = height.Length - 1;

    int area = 0;

    while (x != y)
    {
        int valueX = height[x];
        int valueY = height[y];
        int size = y - x;

        if (valueX > valueY)
        {
            area = Math.Max(valueY * size, area);
            y--;
        }
        else 
        {
            area = Math.Max(valueX * size, area);
            x++;
        }

    }

    return area;
}
