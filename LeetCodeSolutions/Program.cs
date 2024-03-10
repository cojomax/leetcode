// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using Solutions.Easy;
using Solutions.Medium;

// Initialize LeetCode problem here;
var solution = new IntersectionOfTwoArrays();

Console.WriteLine("Running LeetCode problem '{0}. {1}'", solution.Number, solution.GetType().Name);

var result = solution.Solve([1, 2, 2, 1], [2, 2]);

Console.WriteLine("Result: {0}", result);