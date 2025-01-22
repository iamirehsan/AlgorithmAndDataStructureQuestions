using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<(int, int)> intervals = new List<(int, int)>
        {
            (1, 3),
            (2, 6),
            (8, 10),
            (15, 18)
        };

        List<(int, int)> result = MergeIntervals(intervals);

        foreach (var interval in result)
        {
            Console.WriteLine($"({interval.Item1}, {interval.Item2})");
        }
    }

    static List<(int, int)> MergeIntervals(List<(int, int)> intervals)
    {
        if (intervals.Count == 0) return new List<(int, int)>();

        intervals = intervals.OrderBy(interval => interval.Item1).ToList();

        var result = new List<(int, int)>();

        var currentInterval = intervals[0];
        result.Add(currentInterval);

        foreach (var interval in intervals)
        {
            int currentEnd = currentInterval.Item2;
            int nextStart = interval.Item1;
            int nextEnd = interval.Item2;

            if (nextStart <= currentEnd)
            {
                currentInterval = (currentInterval.Item1, Math.Max(currentEnd, nextEnd));
                result[result.Count - 1] = currentInterval;
            }
            else
            {
                currentInterval = interval;
                result.Add(currentInterval);
            }
        }

        return result;
    }
}
