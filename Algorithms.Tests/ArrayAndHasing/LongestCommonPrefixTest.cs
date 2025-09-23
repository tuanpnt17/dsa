using Algorithms.ArrayAndHasing;

namespace Algorithms.Tests.ArrayAndHasing;

public class LongestCommonPrefixTest
{
    [Theory]
    [InlineData(new string[] { "neet", "leet" }, "")]
    [InlineData(new string[] { "bat", "bag", "bank", "band" }, "ba")]
    [InlineData(new string[] { "dance", "dag", "danger", "damage" }, "da")]
    [InlineData(new string[] { "abc", "", "abcd" }, "")]
    [InlineData(new string[] { "longestcommonprefix", "longestcommon", "longest" }, "longest")]
    public void TestFindLongestCommonPrefix(string[] str, string expected)
    {
        var actual = LongestCommonPrefix.FindLongestCommonPrefix(str);
        Assert.Equal(expected, actual);
    }
}
