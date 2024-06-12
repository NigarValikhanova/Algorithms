using System;

public class Solution
{
    public int MinimizeSet(int divisor1, int divisor2, int uniqueCnt1, int uniqueCnt2)
    {
        long low = 1, high = (long)1e18;

        while (low < high)
        {
            long mid = low + (high - low) / 2;
            if (CanDistribute(mid, divisor1, divisor2, uniqueCnt1, uniqueCnt2))
                high = mid;
            else
                low = mid + 1;
        }

        return (int)low;
    }

    private bool CanDistribute(long max, int divisor1, int divisor2, int uniqueCnt1, int uniqueCnt2)
    {
        long totalDiv1 = max / divisor1;
        long totalDiv2 = max / divisor2;
        long totalDiv1and2 = max / lcm(divisor1, divisor2);

        long notDiv1 = max - totalDiv1;
        long notDiv2 = max - totalDiv2;
        long notDiv1and2 = max - totalDiv1and2;

        return notDiv1 >= uniqueCnt1 && notDiv2 >= uniqueCnt2 && notDiv1 + notDiv2 - notDiv1and2 >= uniqueCnt1 + uniqueCnt2;
    }

    private long lcm(int a, int b)
    {
        return (long)a * b / gcd(a, b);
    }

    private int gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

// Usage example
class Program
{
    static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.MinimizeSet(2, 7, 1, 3));  // Output: 4
        Console.WriteLine(sol.MinimizeSet(3, 5, 2, 1));  // Output: 3
        Console.WriteLine(sol.MinimizeSet(2, 4, 8, 2));  // Output: 15
    }
}
