// https://leetcode.com/problems/online-stock-span/description/
public class StockSpanner 
{
    private readonly Stack<(int, int)> _stack;
    public StockSpanner() => _stack = new Stack<(int, int)>();
    
    public int Next(int price) 
    {
        int strike = 1;

        while(_stack.TryPeek(out (int Value, int Strike) peeked) && peeked.Value <= price)
        {
            _stack.Pop();
            strike += peeked.Strike;
        }
        
        _stack.Push((price, strike));
        return strike;
    }
}
