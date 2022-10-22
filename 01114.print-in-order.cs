// https://leetcode.com/problems/print-in-order/description/
using System.Threading;

public class Foo 
{
    private readonly SemaphoreSlim _x;
    private readonly SemaphoreSlim _y;

    public Foo() 
    {
        _x = new SemaphoreSlim(0, 1);
        _y = new SemaphoreSlim(0, 1);
    }

    public void First(Action printFirst) 
    {    
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        _x.Release();
    }

    public void Second(Action printSecond) 
    {
        _x.Wait();
        
        try
        {
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            _y.Release();
        }
        finally
        {
            _x.Release();
        }
    }

    public void Third(Action printThird) 
    {
        _y.Wait();
        
        try
        {
            // printThird() outputs "third". Do not change or remove this line.
            printThird();            
        }
        finally
        {
            _y.Release();
        }
    }
}
