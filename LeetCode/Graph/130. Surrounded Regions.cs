using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph
{
    public class SurroundRegion
    {
 
        public void Solve(char[][] board)
        {

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        AddAllAdjacentLand(i, j, board);
                    }
                }
            }
           
        }

        private void AddAllAdjacentLand(int i, int j, char[][] grid)
        {
            Queue<(int, int)> cellsToCheck = new Queue<(int, int)>();
            Queue<(int, int)> islandCells = new Queue<(int, int)>();
            cellsToCheck.Enqueue((i, j));

            bool isTouchEdge = false;
            while (cellsToCheck.Count > 0)
            {
                var cell = cellsToCheck.Dequeue();
                if ((cell.Item1 >= 0 && cell.Item1 <= grid.Length - 1)
                    && (cell.Item2 >= 0 && cell.Item2 <= grid[0].Length - 1))
                {
                    if (grid[cell.Item1][cell.Item2] == 'O')
                    {
                        cellsToCheck.Enqueue((cell.Item1 + 1, cell.Item2));
                        cellsToCheck.Enqueue((cell.Item1 - 1, cell.Item2));
                        cellsToCheck.Enqueue((cell.Item1, cell.Item2 + 1));
                        cellsToCheck.Enqueue((cell.Item1, cell.Item2 - 1));
                        islandCells.Enqueue(cell);
                        grid[cell.Item1][cell.Item2] = 'X';
                        if (!isTouchEdge && (cell.Item1 == 0 || cell.Item1 == grid.Length - 1 || cell.Item2 == 0 || cell.Item2 == grid[0].Length - 1))
                        {
                            isTouchEdge = true;
                        }
                    }
                   
                }
            }
            if (isTouchEdge)
            {
                while (islandCells.Count > 0)
                {
                    var cellToOverwrite = islandCells.Dequeue();
                    grid[cellToOverwrite.Item1][cellToOverwrite.Item2] = 'O';
                }
            }
           
        }
    }
}
