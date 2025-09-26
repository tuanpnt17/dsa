namespace Algorithms.ArrayAndHashing;

/// <summary>
/// Provides methods to solve the Two Sum problem.
/// </summary>
public class TwoSum
{
    /// <summary>
    /// Finds two indices of numbers in the array that add up to the target value.
    /// Uses a dictionary to store the required difference for each element.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <param name="target">The target sum to find.</param>
    /// <returns>
    /// An array containing the indices of the two numbers that add up to <paramref name="target"/>.
    /// Returns an empty array if no such pair exists.
    /// </returns>
    public static int[] ApproachOne(int[] nums, int target)
    {
        var differences = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (differences.TryGetValue(nums[i], out int value))
            {
                return [value, i];
            }

            var diff = target - nums[i];
            differences.Add(diff, i);
        }

        return [];
    }
}
