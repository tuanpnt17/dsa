namespace Algorithms.ArrayAndHashing;

/// <summary>
/// Provides methods to find the majority element in an array.
/// The majority element is the element that appears more than n/2 times.
/// </summary>
public class MajorityElement
{
    /// <summary>
    /// Finds the majority element using the Boyer-Moore Voting Algorithm.
    /// Assumes that a majority element always exists in the input array.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The majority element.</returns>
    public static int ApproachOne(int[] nums)
    {
        int count = 0;
        int candidate = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }

        return candidate;
    }

    /// <summary>
    /// Finds the majority element using a hash map to count occurrences.
    /// Returns -1 if no majority element exists (should not happen if input is valid).
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The majority element, or -1 if not found.</returns>
    public static int ApproachTwo(int[] nums)
    {
        var counts = new Dictionary<int, int>();
        int majorityCount = nums.Length / 2;
        foreach (int num in nums)
        {
            if (counts.TryGetValue(num, out int value))
            {
                counts[num] = ++value;
            }
            else
            {
                counts[num] = 1;
            }
            if (counts[num] > majorityCount)
            {
                return num;
            }
        }

        return -1; // This line should never be reached if input is valid
    }


}
