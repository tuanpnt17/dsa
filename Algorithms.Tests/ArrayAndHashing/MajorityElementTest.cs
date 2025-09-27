using Algorithms.ArrayAndHashing;

namespace Algorithms.Tests.ArrayAndHashing;

public class MajorityElementTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 3 }, 3)]
    [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 6, 5, 5 }, 5)]
    [InlineData(new int[] { 1, 2, 3, 2, 2 }, 2)]
    [InlineData(new int[] { 4, 4, 4, 4, 2, 2, 4 }, 4)]
    public void TestFindMajorityElement(int[] nums, int expected)
    {
        int result = MajorityElement.ApproachTwo(nums);
        Assert.Equal(expected, result);
    }
}
