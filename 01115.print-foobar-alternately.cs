// https://leetcode.com/problems/print-foobar-alternately/description/
using System.Threading;

public class FooBar 
{
    private int n;
    private readonly SemaphoreSlim _foo = new SemaphoreSlim(1, 1);
    private readonly SemaphoreSlim _bar = new SemaphoreSlim(0, 1);

    public FooBar(int n) {
        this.n = n;
    }

    public void Foo(Action printFoo) 
    {
        
        for (int i = 0; i < n; i++) 
        {
            _foo.Wait();
            
        	// printFoo() outputs "foo". Do not change or remove this line.
        	printFoo();
            
            _bar.Release();
        }
    }

    public void Bar(Action printBar)
    {
        
        for (int i = 0; i < n; i++)
        {
            _bar.Wait();
            
            // printBar() outputs "bar". Do not change or remove this line.
        	printBar();
            
            _foo.Release();
        }
    }
}
