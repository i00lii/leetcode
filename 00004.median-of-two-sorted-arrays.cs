public static double FindMedianSortedArrays(int[] nums1, int[] nums2) 
{
    int totalCount = nums1.Length + nums2.Length;

    int xIdx = 0;
    int yIdx = 0;

    bool isEven = (totalCount % 2) == 0;
    int requiredPosition = (totalCount / 2) - (isEven ? 1 : 0);
    int currentPosition = -1;
    int currentValue = 0;

    while(xIdx < nums1.Length && yIdx < nums2.Length && currentPosition < requiredPosition)
    {
        int xValue = nums1[xIdx];
        int yValue = nums2[yIdx];

        if (xValue < yValue)
        {
            currentValue = xValue;
            xIdx++;
        }
        else
        {
            currentValue = yValue;
            yIdx++;

        }

        currentPosition++;
    }

    for(;xIdx < nums1.Length && currentPosition < requiredPosition; xIdx++)
    {
        currentValue = nums1[xIdx];
        currentPosition++;
    }

    for(;yIdx < nums2.Length && currentPosition < requiredPosition; yIdx++)
    {
        currentValue = nums2[yIdx];
        currentPosition++;
    }

    if (isEven)
    {
        int other = xIdx >= nums1.Length ? nums2[yIdx] 
            : yIdx >= nums2.Length ? nums1[xIdx]
            : Math.Min(nums1[xIdx], nums2[yIdx]);
            
        return ((double)currentValue + other) / 2;
    }
    else 
    {
        return (double)currentValue;
    }
}
