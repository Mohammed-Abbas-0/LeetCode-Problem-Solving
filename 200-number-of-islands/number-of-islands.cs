public class Solution {

    public int NumIslands(char[][] grid)
    {
        if (grid == null || grid.Length == 0)
        return 0;

            int rows = grid.Length;
            int cols = grid[0].Length;

            int max_col = cols-1;
            int max_row = rows-1;

            int islandCount = 0; 

                    Queue<(int, int)> q = new();
            for(int i = 0; i < rows; i++){
                for(int j = 0; j < cols; j++){
                     if (grid[i][j] == '1'){
                        islandCount++;
                        q.Enqueue((i,j));
                        while(q.Count > 0){
                           var (r, c) = q.Dequeue();

if (grid[r][c] == '1')
{
    grid[r][c] = '2';

    if (r > 0)
        q.Enqueue((r - 1, c));

    if (r < max_row)
        q.Enqueue((r + 1, c));

    if (c > 0)
        q.Enqueue((r, c - 1));

    if (c < max_col)
        q.Enqueue((r, c + 1));
} 
                        }

                        
                     }
                }
            }        

        return islandCount;
    }
  
}
