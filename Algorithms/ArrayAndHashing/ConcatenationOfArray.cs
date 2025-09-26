namespace Algorithms.ArrayAndHashing;

/// <summary>
/// Provides methods for array manipulation algorithms.
/// </summary>
public class ConcatenationOfArray
{
    /// <summary>
    /// Returns a new array formed by concatenating the input array with itself.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>An array containing two consecutive copies of <paramref name="nums"/>.</returns>
    public static int[] ApproachOne(int[] nums)
    {
        var n = nums.Length;
        var ans = new int[2 * n];
        for (int i = 0; i < n; i++)
        {
            ans[i] = nums[i];
            ans[i + n] = nums[i];
        }
        return ans;
    }
}
