namespace Algorithms.TwoPointers;

/// <summary>
/// Provides methods to determine if a given string is a valid palindrome,
/// considering only alphanumeric characters and ignoring cases.
/// </summary>
public class ValidPalindrome
{
    /// <summary>
    /// Checks if the input string is a palindrome using the two pointers approach.
    /// Only alphanumeric characters are considered, and case is ignored.
    /// </summary>
    /// <param name="s">The input string to check.</param>
    /// <returns>True if the string is a palindrome; otherwise, false.</returns>
    public static bool ApproachOne(string s)
    {

        if (s.Length == 0 || s.Length == 1) return true;

        s = FormatInputString(s);
        var chars = s.ToCharArray();
        var first = 0;
        var last = chars.Length - 1;

        while (first < last)
        {
            if (chars[first++] != chars[last--]) return false;
        }


        return true;
    }

    /// <summary>
    /// Formats the input string by removing non-alphanumeric characters
    /// and converting all letters to lowercase.
    /// </summary>
    /// <param name="s">The input string to format.</param>
    /// <returns>A formatted string containing only lowercase alphanumeric characters.</returns>
    private static string FormatInputString(string s)
    {
        return new string(s.Trim().ToLower().Where(char.IsLetterOrDigit).ToArray());
    }
}
