namespace Algorithms.ArrayAndHashing;

public class ReverseString
{
    public static void ApproachOne(char[] s)
    {
        var len = s.Length;
        for (var i = 0; i < len / 2; i++)
        {
            // Swap characters with tuple assignment
            (s[len - i - 1], s[i]) = (s[i], s[len - i - 1]);
        }
    }

    public static void ApproachTwo(char[] s)
    {
        Array.Reverse(s);
    }

    public static void ApproachThree(char[] s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            stack.Push(c);
        }

        for (var i = 0; i < s.Length; i++)
        {
            s[i] = stack.Pop();
        }
    }
}
