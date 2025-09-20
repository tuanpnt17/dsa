namespace Algorithms.ArrayAndHasing;

public class ContainsDuplicate
{
    public static bool HasDuplicate(int[] nums)
    {
        var set = new HashSet<int>(nums);

        var setLength = set.Count;

        return setLength != nums.Length;
    }
}
