using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix
{
    public class Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            bool isValid = true;
            HashSet<char> validSet = new();
            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[0].Length; col++)
                {
                    if (board[row][col] != '.') { 
                        if (validSet.Contains(board[row][col])) 
                            return false;
                        else
                            validSet.Add(board[row][col]);
                    }
                }
                validSet.Clear();
            }

            for (int col = 0; col < board[0].Length; col++)
            {
                for (int row = 0; row < board.Length; row++)
                {
                    if (board[row][col] != '.')
                    {
                        if (validSet.Contains(board[row][col])) 
                            return false;
                        else
                            validSet.Add(board[row][col]);
                    }
                }
                validSet.Clear();
            }

            for (int gridRow = 0; gridRow < 3; gridRow++)
            {
                for (int gridCol = 0; gridCol < 3; gridCol++)
                {
                    validSet.Clear();
                    for (int gridCellRow = 0 + 3*gridRow; gridCellRow < 3 + 3*gridRow; gridCellRow++)
                    {
                        for (int gridCellCol = 0 + 3*gridCol; gridCellCol < 3 + 3*gridCol; gridCellCol++)
                        {
                            if (board[gridCellRow][gridCellCol] != '.')
                            {
                                if (validSet.Contains(board[gridCellRow][gridCellCol]))
                                    return false;
                                else
                                    validSet.Add(board[gridCellRow][gridCellCol]);
                            }
                        }
                    }
                   
                }
              
            }

            return isValid;
        }
    }
}
