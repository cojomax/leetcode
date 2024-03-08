using System.Text;

namespace Solutions.Easy;

public class RomanToInteger
{
    public readonly int Number = 13;
    public int Solve(string s)
    {
        // NOTE: This would be faster with a switch statement or for loop without the exceptions dictionary.

        Dictionary<char, int> numerals = new() {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        Dictionary<string, int> exceptions = new()
        {
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },
            { "CD", 400 },
            { "CM", 900 },
        };

        List<int> values = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (i != s.Length - 1 && exceptions.TryGetValue(s.Substring(i, 2), out int value))
            {
                values.Add(value);
                i++;
            }
            else
            {
                values.Add(numerals[s[i]]);
            }

        }

        return values.Sum();
    }
}
