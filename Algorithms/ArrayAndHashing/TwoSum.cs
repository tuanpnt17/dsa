namespace Algorithms.ArrayAndHashing;

public class TwoSum
{
    public static int[] FindTwoSum(int[] nums, int target)
    {
        var differences = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (differences.TryGetValue(nums[i], out int value))
            {
                return [value, i];
            }


            var diff = target - nums[i];
            differences.Add(diff, i);
        }

        return [];
    }
}
