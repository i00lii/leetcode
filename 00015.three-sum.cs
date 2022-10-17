// https://leetcode.com/problems/3sum/description/
public IList<IList<int>> ThreeSum(int[] nums)
{
    const int target = 0;
    Array.Sort(nums);
    List<IList<int>> result = new List<IList<int>>();

    for (int idx = 0; idx < nums.Length - 2;)
    {
        int firstValue = nums[idx];

        int leftIdx = idx + 1;
        int rightIdx = nums.Length - 1;

        int requiredValue = target - firstValue; 

        while (leftIdx < rightIdx)
        {
            int secondValue = nums[leftIdx];
            int thridValue = nums[rightIdx];

            int sum = secondValue + thridValue;

            if (sum == requiredValue)
            {
                result.Add(new int[] {firstValue, secondValue, thridValue});
            }
            if (sum < requiredValue)
            {
                while(leftIdx < rightIdx && nums[leftIdx] == secondValue)
                {
                    leftIdx++;
                }
            }
            else
            {
                while(leftIdx < rightIdx && nums[rightIdx] == thridValue)
                {
                    rightIdx--;
                }
            }   
        }

        do
        {
            idx++;
        }
        while (idx < nums.Length && nums[idx] == firstValue);
    }


    return result;
}
