using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{//https://leetcode.com/problems/zigzag-conversion
    public class ZigzagString
    {
        public string Convert(string s, int numRows)
        {
            if (s.Length <= numRows ||numRows==1) return s;
            int charCount = s.Length;
            int numOfCharInGroup = 2 * numRows - 2;//how many character fits in each column group
            int groupCount = (int)Math.Ceiling((double)charCount / numOfCharInGroup);//how many groups are there to store the string

            int numCols = groupCount * (numRows - 1); //this is a safe boundary for grid column count
            char[,] resultGrid = new char[numRows, numCols]; //initialize result grid
            int row = 0; int col = 0; var charPointer=s.GetEnumerator();
            
            string result = string.Empty;
            for (int i = 0; i < groupCount ; i++) //this loops over the number of group
            { 
                for (int j = 0; j < numOfCharInGroup && charPointer.MoveNext(); j++) // this is based on the number of char in each group
                {
                    if (j < numRows) // if j < than number of Rows then we are going down vertically
                    {
                        resultGrid[row, col] = charPointer.Current;
                        if (j!= numRows-1) 
                            row+=1;
                    }
                    else// j has gone pass the numRows, now we are going diagnal
                    {
                        row -= 1;
                        col += 1;
                        resultGrid[row, col] = charPointer.Current;
                    }
                }
                col += 1;
                row =  0;
                //moving on to the next group, reset to row=0 and advance to next col
            }
            StringBuilder sb = new();
            for (int i = 0; i < numRows; i++)//go through result grid row by row
            {
                for (int j = 0; j < numCols; j++) // in each row, go col by col and skip char 0 (char 0 is the null character)
                {
                    if (resultGrid[i, j] != 0) sb.Append(resultGrid[i, j]);
                }
            }
            return sb.ToString();
        }
    }
}
