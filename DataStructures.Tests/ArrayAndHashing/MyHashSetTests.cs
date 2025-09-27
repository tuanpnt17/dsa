using DataStructures.ArrayAndHashing;

namespace DataStructures.Tests.ArrayAndHashing;

public class MyHashSetTests
{
    [Fact]
    public void TestMyHashSet()
    {
        var hashSet = new MyHashSet();
        hashSet.Add(1);
        hashSet.Add(2);
        Console.WriteLine(hashSet.Contains(1)); // returns true
        Console.WriteLine(hashSet.Contains(3)); // returns false (not found)
        hashSet.Add(2);
        Console.WriteLine(hashSet.Contains(2)); // returns true
        hashSet.Remove(2);
        Console.WriteLine(hashSet.Contains(2)); // returns false (already removed)

        Assert.False(hashSet.Contains(5));
    }
}
