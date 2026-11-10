public class Solution {

public int NumIslands(char[][] grid)
{
    if (grid == null || grid.Length == 0)
        return 0;

    int rows = grid.Length;
    int cols = grid[0].Length;

    int islandCount = 0;

    Stack<(int row, int col)> stack = new();

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            // Find a new island
            if (grid[row][col] == '1')
            {
                islandCount++;

                // Mark as visited
                grid[row][col] = '0';

                // Start DFS
                stack.Push((row, col));

                while (stack.Count > 0)
                {
                    var current = stack.Pop();

                    int r = current.row;
                    int c = current.col;

                    // UP
                    if (r > 0 && grid[r - 1][c] == '1')
                    {
                        grid[r - 1][c] = '0';
                        stack.Push((r - 1, c));
                    }

                    // DOWN
                    if (r < rows - 1 && grid[r + 1][c] == '1')
                    {
                        grid[r + 1][c] = '0';
                        stack.Push((r + 1, c));
                    }

                    // LEFT
                    if (c > 0 && grid[r][c - 1] == '1')
                    {
                        grid[r][c - 1] = '0';
                        stack.Push((r, c - 1));
                    }

                    // RIGHT
                    if (c < cols - 1 && grid[r][c + 1] == '1')
                    {
                        grid[r][c + 1] = '0';
                        stack.Push((r, c + 1));
                    }
                }
            }
        }
    }

    return islandCount;
}
 

    
}



/*
Outer traversal: Loop through every cell in the grid.


DFS traversal: When we find '1', explore all connected land cells.
*/