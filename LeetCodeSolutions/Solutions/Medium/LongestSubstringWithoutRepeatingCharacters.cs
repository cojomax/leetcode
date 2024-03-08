using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solutions.Medium;

public class LongestSubstringWithoutRepeatingCharacters
{
    public readonly int Number = 3;
    public string Solve(string s)
    {
        // FIXME Use the two pointer window approach.

        Dictionary<char, int> memory = new();
        StringBuilder sb = new();

        string longest = "";

        for (int i = 0; i < s.Length; i++)
        {
            // IF Remaining substring is less than current longest substring, stop search
            if (sb.Length == 0 && longest.Length >= 1 && s.Length - i <= longest.Length)
            {
                // No point carrying on.
                break;
            }

            if (memory.TryGetValue(s[i], out int index))
            {
                i = index;
                sb.Clear();
                memory.Clear();

            }
            else
            {
                sb.Append(s[i]);
                memory.Add(s[i], i);

                if (sb.Length > longest.Length)
                {
                    longest = sb.ToString();
                }
            }
        }

        return $"{longest.Length} - {longest}";
    }
}

