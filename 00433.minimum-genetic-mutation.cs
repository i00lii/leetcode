// https://leetcode.com/problems/minimum-genetic-mutation/description/
public class Solution 
{
    public int MinMutation(string start, string end, string[] bank) 
    {
        if (start == end)
            return 0;
        
        int requiredIndex = Array.IndexOf(bank, end) + 1;
        
        if (requiredIndex == 0)
            return -1;

        int size = bank.Length;
        bool[,] mutations = new bool[size + 1, size + 1];

        for (int idx = 0; idx < size; idx++)
        {
            mutations[0, idx + 1] = IsMutationOf(start, bank[idx]);
        }
        
        for (int idx = 0; idx < size; idx++)
        {
            string x = bank[idx];
            
            for(int jdx = 0; jdx < size; jdx++)
            {
                mutations[idx + 1, jdx + 1] = IsMutationOf(x, bank[jdx]);
            }
        }
        
        bool[] visited = new bool[mutations.Length];
        Queue<(int X, int Path)> buffer = new();
        buffer.Enqueue((0, 0));

        while(buffer.TryDequeue(out (int X, int Path) value))
        {
            visited[value.X] = true;
            
            if (value.X == requiredIndex)
            {
                return value.Path;
            }
                
            for(int y = 0; y < size + 1; y++)
            {                
                if (!visited[y] && mutations[value.X, y])
                {
                    buffer.Enqueue((y, value.Path + 1));
                }
            }
        }
        
        return -1;
    }
    
    private static bool IsMutationOf(string x, string y)
    {
        int counter = 0;
        
        for(int idx = 0; idx < x.Length; idx++)
        {
            if (x[idx] != y[idx])
                counter++;
        }
        
        return counter == 1;
    }
}
