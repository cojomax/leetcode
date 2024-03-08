namespace Solutions.Easy;

public class MaxFrequencyElements
{
    public readonly int Number = 3005;
    public int Solve(int[] nums)
    {
        var store = new Dictionary<int, int>();
        var max = 0;

        foreach (int n in nums)
        {
            if (!store.TryAdd(n, 1))
            {
                store[n] += 1;
            }

            max = store[n] > max ? store[n] : max;
        }

        return store.Values.Count(i => i == max) * max;
    }
}