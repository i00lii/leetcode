// https://leetcode.com/problems/flood-fill/description
public class Solution 
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) 
    {
        int originalColor = image[sr][sc];
        if (originalColor == color) return image;

        Fill(sr, sc, originalColor, color, image);
        return image;
    }

    private static void Fill(int r, int c, int originalColor, int targetColor, int[][] image)
    {
        if (r < 0 || c < 0 || r >= image.Length || c >= image[0].Length)
            return;

        ref int pixel = ref image[r][c];

        if (pixel != originalColor)
            return;

        pixel = targetColor;

        Fill(r + 1, c, originalColor, targetColor, image);
        Fill(r, c + 1, originalColor, targetColor, image);
        Fill(r - 1, c, originalColor, targetColor, image);
        Fill(r, c - 1, originalColor, targetColor, image);
    }
}
