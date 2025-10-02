using Algorithms.ArrayAndHashing;

namespace Algorithms.Tests.ArrayAndHashing;

public class ReverseStringTest
{
    [Theory]
    [InlineData(new char[] { 'a', 'b', 'c' }, new char[] { 'c', 'b', 'a' })]
    [InlineData(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
    public void TestReverseString(char[] s, char[] expected)
    {
        // Act
        // ReverseString.ApproachOne(s);
        ReverseString.ApproachTwo(s);
        // ReverseString.ApproachThree(s);

        // Assert
        Assert.Equal(expected, s);
    }
}
