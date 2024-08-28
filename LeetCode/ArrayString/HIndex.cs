using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
    public class HIndexLeet
    {
        //https://leetcode.com/problems/h-index/
        public int HIndex(int[] citations)
        {

                  Array.Sort(citations, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
            //citations.OrderByDescending(x => x).ToArray();

            int hIndex = citations.Length;
            for (int paperCounter=0; paperCounter< citations.Length; paperCounter++)
            {
                if (paperCounter+1 > citations[paperCounter]) {
                    hIndex = paperCounter;
                    break;
                    }
            }

            return hIndex ;
        }
        public int HIndex2(int[] citations) => citations.OrderDescending().Select((index, cites) => new { PaperCount = index , Cites = cites }).Where(r => r.PaperCount > r.Cites).Min(r => r.PaperCount);

    }
}
