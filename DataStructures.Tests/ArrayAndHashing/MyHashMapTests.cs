using DataStructures.ArrayAndHashing;

namespace DataStructures.Tests.ArrayAndHashing;

public class MyHashMapTests
{
    [Fact]
    public void TestMyHashMap()
    {
        var hashMap = new MyHashMap();
        hashMap.Put(1, 1);
        hashMap.Put(2, 2);
        Console.WriteLine(hashMap.Get(1));    // returns 1
        Console.WriteLine(hashMap.Get(3));    // returns -1 (not found)
        hashMap.Put(2, 1);                     // update the existing value
        Console.WriteLine(hashMap.Get(2));    // returns 1
        hashMap.Remove(2);                     // remove the mapping for 2
        Console.WriteLine(hashMap.Get(2));    // returns -1 (not found)

        Assert.Equal(-1, hashMap.Get(5));
    }
}
