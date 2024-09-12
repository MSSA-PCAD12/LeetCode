using LeetCode.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Intervals
{
    public class InsertInterval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            int[][] mergedInterval = new int[intervals.Length+1][];
            for (int i = 0; i < intervals.Length; i++) {
                if (newInterval[0] > intervals[i][0]) {
                    mergedInterval[i] = intervals[i];
                    mergedInterval[i+1] = newInterval;
                    Array.Copy(intervals, i+1, mergedInterval, i + 2, intervals.Length - 1);
                    break;
                }
                else {
                    mergedInterval[i] = intervals[i];
                }
            }
            return Merge(mergedInterval);

        }
        public int[][] Insert2(int[][] intervals, int[] newInterval) {
            LinkedList<int[]> llist = new LinkedList<int[]>(intervals);
            var node = llist.First;
            while (node != null) {
                if (newInterval[0] <= node.Value[1])
                {
                    node.Value[1] = Math.Max(newInterval[1], node.Value[1]);
                   
                }
                if (node.Next != null)
                    {
                        while (node.Value[1] >= node.Next.Value[0])
                        {
                            node.Value[1] = Math.Max(node.Value[1], node.Next.Value[1]);
                            llist.Remove(node.Next);
                        }
                    node = node.Next;
                }else
                {
                    break;
                }
            }
            return llist.ToArray();
        }
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
