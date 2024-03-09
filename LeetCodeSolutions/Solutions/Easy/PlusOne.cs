using System.Diagnostics.SymbolStore;
using System.Numerics;

namespace Solutions.Easy;

public class PlusOne
{
    public readonly int Number = 66;
    public int[] Solve(int[] digits)
    {
        if (digits[^1] == 9)
        {
            string digit = (BigInteger.Parse(string.Join("", digits)) + 1).ToString();
            int[] result = new int[digit.Length];

            for (int i = 0; i < digit.Length; i++)
            {
                result[i] = digit[i] - '0';
            }
            return result;
        }

        digits[^1]++;
        return digits;
    }

}

