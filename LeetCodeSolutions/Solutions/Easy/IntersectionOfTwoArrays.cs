namespace Solutions.Easy;

public class IntersectionOfTwoArrays
{
    public readonly int Number = 349;
    public int[] Solve(int[] nums1, int[] nums2)
    {
        HashSet<int> nums1Set = new HashSet<int>(nums1);
        HashSet<int> nums2Set = new HashSet<int>(nums2);
        nums1Set.IntersectWith(nums2Set);
        return [.. nums1Set];
    }
}
// Tags: Hash Table, Intersection, Set