using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS.Array.TwoSum
{
    public class TwoSum
    {
        public int[] TwoSumBruteForce(int[] a, int t)
        {
            for (int i = 0; i < a.Length - 2; i++)
            {
                for (int j = 1; j < a.Length - 1; j++)
                {
                    if (a[i] + a[j] == t)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
