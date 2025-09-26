namespace Algorithms.ArrayAndHashing;

/// <summary>
/// Provides methods to find the longest common prefix among an array of strings.
/// </summary>
public class LongestCommonPrefix
{
    /// <summary>
    /// Finds the longest common prefix string amongst an array of strings using a horizontal scanning approach.
    /// </summary>
    /// <param name="strs">An array of strings to evaluate.</param>
    /// <returns>
    /// The longest common prefix shared by all strings in <paramref name="strs"/>. 
    /// Returns an empty string if there is no common prefix.
    /// </returns>
    public static string ApproachOne(string[] strs)
    {
        var prefix = strs[0];

        for (var i = 1; i < strs.Length; i++)
        {
            var j = 0;
            var current = strs[i];

            while (j < Math.Min(prefix.Length, current.Length))
            {
                if (current[j] != prefix[j]) break;
                j++;
            }

            prefix = prefix[..j];
        }

        return prefix;
    }
}
