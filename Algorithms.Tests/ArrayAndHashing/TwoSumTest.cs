using Algorithms.ArrayAndHashing;

namespace Algorithms.Tests.ArrayAndHashing;

public class TwoSumTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 7, new int[] { 2, 3 })]
    [InlineData(new int[] { 3, 4, 5, 6 }, 7, new int[] { 0, 1 })]
    public void TestFindTwoSum(int[] nums, int target, int[] expected)
    {
        var actual = TwoSum.FindTwoSum(nums, target);
        Assert.Equal(expected, actual);
    }
}
