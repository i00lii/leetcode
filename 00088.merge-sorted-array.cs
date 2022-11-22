// https://leetcode.com/problems/merge-sorted-array/description
public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int idxM = m - 1;
        int idxN = n - 1;
        
        int idxR = nums1.Length - 1;

        while (idxM >= 0 && idxN >= 0)
        {
            int valueM = nums1[idxM];
            int valueN = nums2[idxN];
            
            if (valueM > valueN)
            {
                nums1[idxR--] = valueM;
                idxM--;
            }
            else 
            {
                nums1[idxR--] = valueN;
                idxN--;
            }
        }

        for (;idxN >= 0; idxN--)
        {
            nums1[idxR--] = nums2[idxN];
        }
    }
}
