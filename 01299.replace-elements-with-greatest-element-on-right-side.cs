// https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/description/
public class Solution 
{
    public int[] ReplaceElements(int[] arr) 
    {
        int popped = -1;

        for (int idx = arr.Length - 1; idx >= 0; idx--)
        {
            int current = arr[idx];
            arr[idx] = popped;
            
            popped = Math.Max(current, popped);
        }
        
        return arr;
    }
}
