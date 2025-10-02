namespace Algorithms.TwoPointers;

public class ValidPalindrome
{
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

    private static string FormatInputString(string s)
    {
        return new string(s.Trim().ToLower().Where(char.IsLetterOrDigit).ToArray());
    }
}
