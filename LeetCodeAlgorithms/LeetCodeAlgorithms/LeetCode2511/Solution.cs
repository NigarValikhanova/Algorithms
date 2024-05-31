using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.LeetCode2511
{
    public class Solution
    {
        public int CaptureForts(int[] forts)
        {
            int n = forts.Length;
            int maxCaptured = 0;

            for (int i = 0; i < n; i++)
            {
                if (forts[i] == 1)
                {
                    // Check to the right
                    int captured = 0;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (forts[j] == 0)
                        {
                            captured++;
                        }
                        else if (forts[j] == -1)
                        {
                            maxCaptured = Math.Max(maxCaptured, captured);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }

                    // Check to the left
                    captured = 0;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (forts[j] == 0)
                        {
                            captured++;
                        }
                        else if (forts[j] == -1)
                        {
                            maxCaptured = Math.Max(maxCaptured, captured);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return maxCaptured;
        }
    }
}
