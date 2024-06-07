using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.LeetCode2512
{

    public class Solution
    {
        public IList<int> TopKStudents(string[] positive_feedback, string[] negative_feedback, string[] report, int[] student_id, int k)
        {
            // Convert positive and negative feedback arrays to hash sets for O(1) lookup
            var positiveWords = new HashSet<string>(positive_feedback);
            var negativeWords = new HashSet<string>(negative_feedback);

            // Dictionary to keep track of student scores
            var studentScores = new Dictionary<int, int>();

            // Calculate scores for each student based on their reports
            for (int i = 0; i < report.Length; i++)
            {
                var words = report[i].Split(' ');
                int score = 0;
                foreach (var word in words)
                {
                    if (positiveWords.Contains(word))
                    {
                        score += 3;
                    }
                    else if (negativeWords.Contains(word))
                    {
                        score -= 1;
                    }
                }

                if (!studentScores.ContainsKey(student_id[i]))
                {
                    studentScores[student_id[i]] = 0;
                }
                studentScores[student_id[i]] += score;
            }

            // Sort the students first by score in descending order, then by ID in ascending order
            var sortedStudents = studentScores
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key)
                .Take(k)
                .Select(s => s.Key)
                .ToList();

            return sortedStudents;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var solution = new Solution();

            string[] positive_feedback = { "smart", "brilliant", "studious" };
            string[] negative_feedback = { "not" };
            string[] report = { "this student is studious", "the student is smart" };
            int[] student_id = { 1, 2 };
            int k = 2;

            var result = solution.TopKStudents(positive_feedback, negative_feedback, report, student_id, k);

            Console.WriteLine(string.Join(", ", result)); // Output: [1, 2]

            string[] report2 = { "this student is not studious", "the student is smart" };
            int[] student_id2 = { 1, 2 };

            var result2 = solution.TopKStudents(positive_feedback, negative_feedback, report2, student_id2, k);

            Console.WriteLine(string.Join(", ", result2)); // Output: [2, 1]
        }
    }
}