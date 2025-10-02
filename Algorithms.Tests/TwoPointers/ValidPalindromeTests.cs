using Algorithms.TwoPointers;

namespace Algorithms.Tests.TwoPointers;

public class ValidPalindromeTests
{
    [Theory]
    [InlineData("123321", true)]
    [InlineData("tab a cat", false)]
    [InlineData("Was it a car or a cat I saw?", true)]
    public void TestValidPalindrome(string s, bool expected)
    {
        var actual = ValidPalindrome.ApproachOne(s);
        Assert.Equal(expected, actual);
    }
}
