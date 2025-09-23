namespace Algorithms.ArrayAndHashing;

public class ConcatenationOfArray
{
    public static int[] GetConcatenation(int[] nums)
    {
        var n = nums.Length;
        var ans = new int[2 * n];
        for (int i = 0; i < n; i++)
        {
            ans[i] = nums[i];
            ans[i + n] = nums[i];
        }
        return ans;
    }
}
