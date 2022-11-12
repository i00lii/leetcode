// https://leetcode.com/problems/find-median-from-data-stream/description/
public class MedianFinder 
{
    private readonly PriorityQueue<int, int> _mins = new ();
    private readonly PriorityQueue<int, int> _maxs = new ();

    private int _totalCount = 0;

    public void AddNum(int num) 
    {
        if (_totalCount % 2 == 0)
        {
            int buffer = _maxs.EnqueueDequeue(num, num);
            _mins.Enqueue(buffer, -buffer);
        }
        else 
        {
            int buffer = _mins.EnqueueDequeue(num, -num);
            _maxs.Enqueue(buffer, buffer);
        }

        _totalCount++;
    }
    
    public double FindMedian()
        => (_totalCount) % 2 == 1
        ? (double)_mins.Peek()
        : (double)(_mins.Peek() + _maxs.Peek()) / 2;
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */
