// https://leetcode.com/problems/check-if-n-and-its-double-exist/description/ 
public class Solution 
{
    public bool CheckIfExist(int[] arr) 
    {
        HashSet<int> buffer = new();
        
        for (int idx = 0; idx < arr.Length; idx++)
        {
            int current = arr[idx];
            
            if (buffer.Contains(current * 2)) return true;
            
            if (current % 2 == 0)
            {
                int down = current / 2;
                if (buffer.Contains(down)) return true;
            }
            
            buffer.Add(current);
        }
        
        return false;
    }
}
