public class Solution {

    //we hit every element in this 2d array so O(m x n)
    public int NumIslands(char[][] grid) {

        //start out with some initial err handling
        if (grid == null || grid.Length == 0)
        {
            return 0;
        }

        int numIslands = 0;

        //lets start by traversing the matrix
        for(int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                Console.Write(" " + grid[i][j] + " ");
                if (grid[i][j] == '1') {
                    //we want to backtrack all 1s on this island before incr
                    numIslands += DFS(grid,i,j);
                }
            }
            Console.WriteLine();
        }

        return numIslands;
    }

    public int DFS(char[][] grid, int i, int j) {
        //if pointer above,below,left,right of grid or at a 0 point
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0') {
            return 0;
        }

        //sink this part of island
        grid[i][j] = '0';
        //check cardinal to current location
        //check down
        DFS(grid, i + 1, j);
        //check up
        DFS(grid, i - 1, j);
        //check right
        DFS(grid, i, j + 1);
        //check left
        DFS(grid, i, j - 1);

        //all neighbors sunk ie island sunk
        //we can now increment
        return 1;
    }
}
