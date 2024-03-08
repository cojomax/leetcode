// See https://aka.ms/new-console-template for more information
using Solutions.Easy;

// Initialize LeetCode problem here;
var solution = new RomanToInteger();

Console.WriteLine("Running LeetCode problem '{0}. {1}'", solution.Number, solution.GetType().Name);

var result = solution.Solve("MCMXCIV");

Console.WriteLine("Result: {0}", result);