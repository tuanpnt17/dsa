using Algorithms.TwoPointers;

namespace Algorithms.Tests.TwoPointers;

public class ValidPalindromeIITests
{
    [Theory]
    [InlineData("aca", true)]
    [InlineData("ac", true)]
    [InlineData("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga", true)]
    [InlineData("abbadc", false)]
    [InlineData("tadffdaet", true)]
    public void TestValidPalindromeII(string s, bool expected)
    {
        var actual = ValidPalindromeII.ApproachOne(s);
        Assert.Equal(expected, actual);
    }
}
