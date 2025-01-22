using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = new List<int>() { 10, 14, 18, 7 };
        var target = 21;
        var result = TwoSum(numbers, target);
        Console.WriteLine($"Indices: {result[0]}, {result[1]}");

        List<int> TwoSum(List<int> numbers, int target)
        {
            var numAndIndex = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int complement = target - numbers[i];

                if (numAndIndex.ContainsKey(complement))
                {
                    return new List<int> { numAndIndex[complement], i };
                }

                numAndIndex[numbers[i]] = i;
            }

            throw new Exception("No solution found");
        }
    }
}
