// https://leetcode.com/problems/nearest-exit-from-entrance-in-maze/
public class Solution 
{
    public int NearestExit(char[][] maze, int[] entrance) 
    {
        const char wall = '+';
        int sizeX = maze[0].Length;
        int sizeY = maze.Length;

        Queue<(int X, int Y, int Path)> queue = new ();
        queue.Enqueue((entrance[1], entrance[0], 0));
        while (queue.TryDequeue(out (int X, int Y, int Path) value))
        {
            (int x, int y, int path) = value;
            if (IsWallOrOutOfMaze(x, y)) continue;
            if (IsExit(x, y, path)) return path;

            maze[y][x] = wall;
            int childPath = path + 1;

            queue.Enqueue((x, y + 1, childPath));
            queue.Enqueue((x + 1, y, childPath));
            queue.Enqueue((x, y - 1, childPath));
            queue.Enqueue((x - 1, y, childPath));
        }

        return -1;

        bool IsWallOrOutOfMaze(int x, int y) => x < 0 || x >= sizeX || y < 0 || y >= sizeY || maze[y][x] == wall;
        bool IsExit(int x, int y, int path) => path != 0 && (x == 0 || y == 0 || x == sizeX - 1 || y == sizeY - 1);
    }
}
