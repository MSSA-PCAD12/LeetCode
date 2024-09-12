using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Intervals
{
    public class MergeInterval
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, new Comparison<int[]>(
                  (x, y) => { return x[0] - y[0]; })); //first sort the array on first element of each child array

            List<int[]> result = new(); //list to keep the result
            for (int i = 0; i < intervals.Length; i++) // go through each pair in the array
            {
                if (i == intervals.Length - 1) //the last one in the array, add to the result
                {
                    result.Add(intervals[i]);
                }
                else
                {
                    if (intervals[i + 1][0] >= intervals[i][0] && intervals[i + 1][0] <= intervals[i][1])
                        //does the current array item overlaps next array item?
                    {
                        intervals[i + 1][0] = Math.Min(intervals[i][0], intervals[i + 1][0]);
                        intervals[i + 1][1] = Math.Max(intervals[i][1], intervals[i + 1][1]);
                        //expand the next array item to include both current and next item
                    }
                    else  //if next item is not overlapping with current item, we should add the current item to
                          // result list
                    { result.Add(intervals[i]); }
                }
            }
            return result.ToArray();//covert List<int[]> to int[][]
        }
    }
}
