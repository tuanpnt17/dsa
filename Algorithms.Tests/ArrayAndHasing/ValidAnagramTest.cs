using Algorithms.ArrayAndHasing;

namespace Algorithms.Tests.ArrayAndHasing;

public class ValidAnagramTest
{
    [Theory]
    [InlineData("racecar", "carrace", true)]
    [InlineData("jar", "jam", false)]
    public void TestIsAnagram(string s, string t, bool expected)
    {
        var actual = ValidAnagram.IsAnagram(s, t);
        Assert.Equal(expected, actual);
    }
}
