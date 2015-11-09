using System;
using System.Linq;

namespace ArrayMinMaxSolution.Service
{
    public class Solution
    {
        private int[] _B;
        private int _minNotInArray;
        public int MinElementNonInArray {
            get
            {
                return _minNotInArray;
            }
        }

        public Solution(int[] A)
        {
            if (A.Length == 0) { throw new ArgumentException(); }
            _B = A;
            _minNotInArray = _minArrayElementNotInArray(_B);
        }

        /// <summary>
        /// Minimum element not present in a given array
        /// </summary>
        /// <param name="B"></param>
        /// <returns></returns>
        private int _minArrayElementNotInArray(int[] B)
        {
            int minElement = -1;
            int min = B.Min();
            int max = B.Max();

            for(int i = min; i < max; i++)
            {
                if (Array.Exists(B, e => e == i))
                {
                    continue;
                }
                else
                {
                    minElement = i;
                    break;
                }

            }

            return minElement;
        }
    }
}
