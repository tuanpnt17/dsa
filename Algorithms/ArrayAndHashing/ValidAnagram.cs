namespace Algorithms.ArrayAndHashing;

/// <summary>
/// Provides methods to determine if two strings are anagrams.
/// </summary>
public class ValidAnagram
{

    /// <summary>
    /// Determines whether two strings are anagrams of each other.
    /// An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.
    /// This approach uses a dictionary to count character occurrences in both strings simultaneously.
    /// </summary>
    /// <param name="s">The first input string.</param>
    /// <param name="t">The second input string.</param>
    /// <returns>
    /// True if <paramref name="s"/> and <paramref name="t"/> are anagrams; otherwise, false.
    /// </returns>
    public static bool ApproachOne(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var dic = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var sChar = s[i];
            var tChar = t[i];

            if (!dic.TryGetValue(sChar, out int svalue)) dic.Add(sChar, 1);
            else
                dic[sChar] = ++svalue;

            if (!dic.TryGetValue(tChar, out int tvalue)) dic.Add(tChar, -1);
            else dic[tChar] = --tvalue;

        }

        foreach (var item in dic)
        {
            if (item.Value != 0) return false;
        }

        return true;

    }

    /// <summary>
    /// Determines whether two strings are anagrams of each other using a fixed-size array for character counting.
    /// This approach assumes the strings contain only lowercase English letters.
    /// </summary>
    /// <param name="s">The first input string.</param>
    /// <param name="t">The second input string.</param>
    /// <returns>
    /// True if <paramref name="s"/> and <paramref name="t"/> are anagrams; otherwise, false.
    /// </returns>
    public static bool ApproachTwo(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var count = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach (var item in count)
        {
            if (item != 0) return false;
        }

        return true;

    }
}
