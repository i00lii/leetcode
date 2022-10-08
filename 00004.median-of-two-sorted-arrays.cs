public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
{
    int totalCount = nums1.Length + nums2.Length;

    int xIdx = 0;
    int yIdx = 0;

    bool isEven = (totalCount % 2) == 0;
    int requiredPosition = totalCount / 2;
    int currentPosition = -1;

    int previousValue = 0;
    int currentValue = 0;

    while(xIdx < nums1.Length && yIdx < nums2.Length && currentPosition < requiredPosition)
    {
        int xValue = nums1[xIdx];
        int yValue = nums2[yIdx];

        if (xValue < yValue)
        {
            previousValue = currentValue;
            currentValue = xValue;
            xIdx++;
        }
        else
        {
            previousValue = currentValue;
            currentValue = yValue;
            yIdx++;

        }

        currentPosition++;
    }

    for(;xIdx < nums1.Length && currentPosition < requiredPosition; xIdx++)
    {
        previousValue = currentValue;
        currentValue = nums1[xIdx];
        currentPosition++;
    }

    for(;yIdx < nums2.Length && currentPosition < requiredPosition; yIdx++)
    {
        previousValue = currentValue;
        currentValue = nums2[yIdx];
        currentPosition++;
    }

    if (isEven)
    {
        return ((double)currentValue + previousValue) / 2;
    }
    else 
    {
        return (double)currentValue;
    }
}
