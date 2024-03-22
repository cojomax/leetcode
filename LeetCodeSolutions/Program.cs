// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using Solutions.Easy;
using Solutions.Medium;

// Initialize LeetCode problem here;
var solution = new ValidSudoku();

Console.WriteLine("Running LeetCode problem '{0}. {1}'", solution.Number, solution.GetType().Name);

var result = solution.Solve([
    ['.','.','.','.','.','.','5','.','.'],
    ['.','.','.','.','.','.','.','.','.'],
    ['.','.','.','.','.','.','.','.','.'],
    ['9','3','.','.','2','.','4','.','.'],
    ['.','.','7','.','.','.','3','.','.'],
    ['.','.','.','.','.','.','.','.','.'],
    ['.','.','.','3','4','.','.','.','.'],
    ['.','.','.','.','.','3','.','.','.'],
    ['.','.','.','.','.','5','2','.','.']
]);

Console.WriteLine("Result: {0}", result);