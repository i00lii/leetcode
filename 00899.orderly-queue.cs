// https://leetcode.com/problems/orderly-queue/description/
public class Solution 
{
    public string OrderlyQueue(string s, int k) 
    {
        char[] buffer = s.ToCharArray();

        if (k > 1)
        {
            Array.Sort(buffer);
            return new string(buffer);
        }

        int length = buffer.Length;
        char[] temp = new char[length];
        char[] min = new char[length];
        Array.Copy(buffer, min, length);
        
        for(int idx = 0; idx < length; idx++)
        {
            int headSize = idx + 1;
            int tailSize = length - headSize;

            Array.Copy(buffer, 0, temp, tailSize, headSize);
            Array.Copy(buffer, headSize, temp, 0, tailSize);

            for(int jdx = 0; jdx < length; jdx++)
            {
                char x = min[jdx];
                char y = temp[jdx];

                if (y < x) 
                {
                    Array.Copy(temp, min, length);
                    break;
                }
                else if (y > x)
                {
                    break;
                }
            }
            
        }

        return new string(min);
    }
}
