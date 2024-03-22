using System.Globalization;

namespace Solutions.Medium;

public class ValidSudoku
{
    public readonly int Number = 36;
    public bool Solve(char[][] board)
    {
        var size = 9;
        var nums = new HashSet<char>(size);

        // Check each row
        for (int i = 0; i < size; i++)
        {
            nums.Clear();
            for (int j = 0; j < size; j++)
            {
                var value = board[i][j];
                if (!TryAdd(nums, value)) return false;
            }
        }

        // Check each column
        for (int j = 0; j < size; j++)
        {
            nums.Clear();
            for (int i = 0; i < size; i++)
            {
                var value = board[i][j];
                if (!TryAdd(nums, value)) return false;
            }
        }

        // TODO Check each 3x3 box
        int row = 0, col = 0;

        while (row < size)
        {
            nums.Clear();
            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    var value = board[i][j];
                    if (!TryAdd(nums, value)) return false;
                }
            }
            col += 3;
            if (col >= size)
            {
                row += 3;
                col = 0;
            }
        }

        return true;
    }

    private static bool TryAdd(HashSet<char> nums, char value)
    {
        if (value == '.') return true;
        return nums.Add(value);
    }
}