// https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/
public class Solution 
{
    public int MaxLength(IList<string> arr) 
    {
        uint[] buffer = new uint[arr.Count];
        uint result = 0;

        for (int idx = 0; idx < arr.Count; idx++)
        {
            uint mask = 0;

            foreach (char letter in arr[idx])
            {
                uint bit = (uint)(1 << letter - 'a');

                if ((mask & bit) != 0)
                {
                    mask = uint.MaxValue;
                    break;
                }

                mask ^= bit;
            }

            buffer[idx] = mask;
        }

        Stack<Context> stack = new Stack<Context>();

        for (int idx = 0; idx < buffer.Length; idx++)
        {
            uint mask = buffer[idx];

            if (mask != uint.MaxValue)
            {
                result = Math.Max(System.Runtime.Intrinsics.X86.Popcnt.PopCount(mask), result);
                stack.Push(new Context(idx, mask));
            }
        }

        while (stack.TryPop(out Context current))
        {
            for (int idx = current.Idx + 1; idx < buffer.Length; idx++)
            {
                uint next = buffer[idx];

                if ((next & current.AccumulatedValue) == 0)
                {
                    uint mask = next | current.AccumulatedValue;
                    result = Math.Max(System.Runtime.Intrinsics.X86.Popcnt.PopCount(mask), result);
                    stack.Push(new Context(idx, mask));
                }
            }
        }

        return (int)result;
    }

    private readonly struct Context
    {
        public readonly int Idx;
        public readonly uint AccumulatedValue;

        public Context(int idx, uint accumulatedValue)
        {
            Idx = idx;
            AccumulatedValue = accumulatedValue;
        }
    }
}
