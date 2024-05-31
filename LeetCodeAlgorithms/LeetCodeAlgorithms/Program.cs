// See https://aka.ms/new-console-template for more information
using LeetCodeAlgorithms.LeetCode2511;

Console.WriteLine("Hello, World!");

int[] forts = [0, 0, 0, 1, 0, 0, 0, -1, 0, 0, 0, 0, 1];

Solution solution = new Solution();

Console.WriteLine(solution.CaptureForts(forts));