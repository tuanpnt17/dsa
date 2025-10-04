namespace Algorithms.TwoPointers;

public class ValidPalindromeII
{
    public static bool ApproachOne(string s)
    {
        int l = 0, r = s.Length - 1;

        while (l < r)
        {
            if (s[l] != s[r])
            {
                string skipL = s.Substring(l + 1, r - l);
                string skipR = s[l..r];
                return IsPalindrome(skipL) || IsPalindrome(skipR);
            }
            l++;
            r--;
        }

        return true;
    }

    private static bool IsPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}
