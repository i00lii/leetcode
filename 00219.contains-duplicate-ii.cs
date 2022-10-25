// https://leetcode.com/problems/contains-duplicate-ii/description/
public bool ContainsNearbyDuplicate(int[] nums, int k) 
{
    if (k == 0)
        return false;

    HashSet<int> lookup = new HashSet<int>(k);

    for(int idx = 0; idx < Math.Min(k, nums.Length); idx++)
    {
        if (!lookup.Add(nums[idx]))
        {
            return true;
        }
    }

    for(int idx = k; idx < nums.Length; idx++)
    {
        int current = nums[idx];
        int old = nums[idx - k];

        if (!lookup.Add(current))
        {
            return true;
        }

        lookup.Remove(old);
    }

    return false;
}
