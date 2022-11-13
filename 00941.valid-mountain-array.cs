// https://leetcode.com/problems/valid-mountain-array/description/
public class Solution 
{
    public bool ValidMountainArray(int[] arr) 
    {
        if (arr.Length < 3 || arr[0] >= arr[1] || arr[arr.Length - 2] <= arr[arr.Length -1])
            return false;
        
        int peaks = 0;
        
        for(int x = 0; x < arr.Length - 2; x++)
        {
            int xValue = arr[x];
            int yValue = arr[x + 1];
            int zValue = arr[x + 2];
            
            if (xValue == yValue || zValue == yValue)
                return false;

            if (yValue > xValue && yValue > zValue)
                peaks++;
        }
        
        return peaks == 1;
    }
}
