using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
    public class CanCompleteCircuitLeet
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas.Sum() < cost.Sum()) return -1; //deal with test cases that has 99,999 1's

            IEnumerable<int> candidates =
            Enumerable.Range(0, gas.Length).Where(index =>
            gas[index] != 0 && //any station with 0 gas is not a candidate
            gas[index] >= cost[index] //any station with less gas than cost to next station is not a candidate
            );

            foreach (int station in candidates)
            {
                int startingStation = station;
                int currentStation = station;
                int gasLevel = gas[currentStation];
                while (gasLevel - cost[currentStation] >= 0)
                {
                    gasLevel -= cost[currentStation];
                    currentStation++;
                    currentStation = currentStation % gas.Length;

                    gasLevel += gas[currentStation];
                    if (currentStation == startingStation) return startingStation;
                };
            }
            return -1;
        }
    }
}
