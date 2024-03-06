using System.Text;

namespace Solutions.Easy;

public class RansomNote
{
    public readonly int Number = 383;
    public bool Solve(string ransomNote, string magazine)
    {
        Dictionary<char, int> library = new Dictionary<char, int>();

        foreach (char c in magazine)
        {
            if (library.TryGetValue(c, out int value))
            {
                library[c] = value + 1;
            }
            else
            {
                library.Add(c, 1);
            }
        }

        StringBuilder sb = new StringBuilder();

        foreach (char c in ransomNote)
        {
            if (library.TryGetValue(c, out int value) && value > 0)
            {
                sb.Append(c);
                library[c] = value - 1;
            }
        }
        return ransomNote == sb.ToString();
    }
}
