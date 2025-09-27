using Algorithms.ArrayAndHashing;

namespace Algorithms.Tests.ArrayAndHashing;

public class ConcatenationOfArrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 2 }, new int[] { 1, 2, 1, 2 })]
    [InlineData(new int[] { 0, 1, 5 }, new int[] { 0, 1, 5, 0, 1, 5 })]
    public void GetConcatenationTest(int[] nums, int[] expected)
    {
        var result = ConcatenationOfArray.ApproachOne(nums);
        Assert.Equal(expected, result);
    }
}
