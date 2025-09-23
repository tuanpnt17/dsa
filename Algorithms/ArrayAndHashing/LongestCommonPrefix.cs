namespace Algorithms.ArrayAndHashing;

public class LongestCommonPrefix
{
    public static string FindLongestCommonPrefix(string[] strs)
    {
        var result = strs[0];

        for (var i = 1; i < strs.Length; i++)
        {
            var j = 0;
            var current = strs[i];

            while (j < Math.Min(result.Length, current.Length))
            {
                if (current[j] != result[j]) break;
                j++;
            }

            result = result[..j];
        }

        return result;
    }
}
