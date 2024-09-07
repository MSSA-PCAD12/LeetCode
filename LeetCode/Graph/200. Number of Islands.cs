using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph
{//https://leetcode.com/problems/number-of-islands
    public class NumIslandsLeet
    {
      
      
        public int NumIslands(char[][] grid)
        {
            int numOfIslands = 0;

            for (int i = 0; i < grid.Length; i++) {
                for (int j = 0; j < grid[i].Length; j++) {
                    if (grid[i][j] == '1') {
                        AddAllAdjacentLand(i,j,grid);
                        numOfIslands++;
                    }
                }
            }
            return numOfIslands;
        }

        private void AddAllAdjacentLand(int i, int j, char[][] grid)
        {
            Queue<(int,int)> cellsToCheck = new Queue<(int,int)> ();
            cellsToCheck.Enqueue((i, j));
            while (cellsToCheck.Count > 0)
            {
                var cell = cellsToCheck.Dequeue();
                if ((cell.Item1 >= 0 && cell.Item1 <= grid.Length - 1)
                    && (cell.Item2 >= 0 && cell.Item2 <= grid[0].Length - 1)) {
                    if (grid[cell.Item1][cell.Item2] == '1')
                    {
                        cellsToCheck.Enqueue((cell.Item1 + 1, cell.Item2));
                        cellsToCheck.Enqueue((cell.Item1 - 1, cell.Item2));
                        cellsToCheck.Enqueue((cell.Item1, cell.Item2 + 1));
                        cellsToCheck.Enqueue((cell.Item1, cell.Item2 - 1));
                        grid[cell.Item1][cell.Item2] = '0';
                    }
                }
            }
        }
    }
}
