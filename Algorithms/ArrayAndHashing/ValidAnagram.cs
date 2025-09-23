namespace Algorithms.ArrayAndHashing;

public class ValidAnagram
{

    /// <summary>
    ///Given two strings s and t, return true if the two strings are anagrams of each other, otherwise return false.
    ///An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.
    /// </summary>
    public static bool IsAnagram(string s, string t)
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
}
