// https://leetcode.com/problems/intersection-of-two-arrays-ii/description/
public class Solution 
{
    public int[] Intersect(int[] nums1, int[] nums2) 
    {
        (nums1, nums2) = nums1.Length < nums2.Length ? (nums1, nums2) : (nums2, nums1);

        int max = nums1.Length;
        Dictionary<int, int> buffer = new ();

        foreach (int number in nums1)
        {
            if (!buffer.ContainsKey(number)) buffer[number] = 1;
            else buffer[number]++;
        }

        List<int> result = new ();
        foreach (int number in nums2)
        {
            if (max <= 0) break;

            if (buffer.ContainsKey(number))
            {
                int count = buffer[number] - 1;
                result.Add(number);

                if (count > 0) buffer[number] = count;
                else buffer.Remove(number);

                max--;
            }
        }

        return result.ToArray();
    }
}
