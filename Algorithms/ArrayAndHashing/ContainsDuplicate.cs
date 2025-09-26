namespace Algorithms.ArrayAndHashing;

/// <summary>
/// Provides methods to check for duplicates in an array.
/// </summary>
public class ContainsDuplicate
{
    /// <summary>
    /// Determines whether the input array contains any duplicate elements.
    /// </summary>
    /// <param name="nums">The array of integers to check for duplicates.</param>
    /// <returns>
    /// True if there is at least one duplicate element in <paramref name="nums"/>; otherwise, false.
    /// </returns>
    public static bool ApproachOne(int[] nums)
    {
        var set = new HashSet<int>(nums);

        var setLength = set.Count;

        return setLength != nums.Length;
    }
}
