using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_warm_up
{
    public class FindMatches
    {
        public bool FindJustA(string[] input)
        {
            return input is ["A"];
        }

        public bool FindNorthCodersMatches(string[] input)
        {
            return input is [_, _, "Northcoders"];
        }

        public int CountSpecificArrays(int[][] jaggedArray)
        {
            //return jaggedArray.Count(x => x is [4, ..] && x.Contains(3));

            int matches = 0;
            foreach (var array in jaggedArray)
            {
                if (array is [4, ..] && array.Contains(3)) matches++;
            }
            return matches;
        }
    }
}
