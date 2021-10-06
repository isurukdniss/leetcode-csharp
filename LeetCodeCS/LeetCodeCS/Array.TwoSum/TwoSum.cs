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
            if (a.Length == 0 || a.Length == 1)
            {
                return null;
            }

            for (int i = 0; i < a.Length - 2; i++)
            {
                for (int j = i + 1; j < a.Length - 1; j++)
                {
                    int remainder = t - a[i];
                    if (a[j] == remainder)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
