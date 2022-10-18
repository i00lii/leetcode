// https://leetcode.com/problems/3sum-closest/description/
public int ThreeSumClosest(int[] nums, int target) 
{
    Array.Sort(nums);
    int result = int.MaxValue;
    int delta = Math.Abs(target - result); 

    for(int firstIdx = 0; firstIdx < nums.Length - 2; firstIdx++)
    {
        int firstValue = nums[firstIdx];

        int leftIdx = firstIdx + 1;
        int rightIdx = nums.Length - 1;

        while(leftIdx < rightIdx)
        {
            int current = firstValue + nums[leftIdx] + nums[rightIdx];

            if (current == target)
            {
                return current;
            } 
            else if (current < target)
            {
                rightIdx--;
            }
            else
            {
                leftIdx++;
            }

            if (Math.Abs(target - current) is int newDelta && newDelta < delta)
            {
                result = current;
                delta = newDelta;
            }
        }
    }


    return result;
}

