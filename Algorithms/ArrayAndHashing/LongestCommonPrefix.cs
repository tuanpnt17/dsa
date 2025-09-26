namespace Algorithms.ArrayAndHashing;

public class LongestCommonPrefix
{
    public static string FindLongestCommonPrefix(string[] strs)
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
