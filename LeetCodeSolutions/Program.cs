// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using Solutions.Easy;
using Solutions.Medium;

// Initialize LeetCode problem here;
var solution = new PlusOne();

Console.WriteLine("Running LeetCode problem '{0}. {1}'", solution.Number, solution.GetType().Name);

var result = solution.Solve([5,6,2,0,0,4,6,2,4,9]);

Console.WriteLine("Result: {0}", result);