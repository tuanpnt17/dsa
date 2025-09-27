namespace DataStructures.ArrayAndHashing;

/// <summary>
/// Implements a simple hash set for integers using separate chaining with linked lists.
/// </summary>
public class MyHashSet
{
    /// <summary>
    /// The number of buckets in the hash set. A prime number is used for better distribution.
    /// </summary>
    private const int SIZE = 1009;

    /// <summary>
    /// The array of buckets, each a linked list to handle collisions.
    /// </summary>
    private readonly LinkedList<int>[] _buckets;

    /// <summary>
    /// Initializes a new instance of the <see cref="MyHashSet"/> class.
    /// </summary>
    public MyHashSet()
    {
        _buckets = new LinkedList<int>[SIZE];
        for (int i = 0; i < SIZE; i++)
            _buckets[i] = new LinkedList<int>();
    }

    /// <summary>
    /// Computes the hash code for the given key.
    /// </summary>
    /// <param name="key">The integer key to hash.</param>
    /// <returns>The index of the bucket for the key.</returns>
    private static int Hash(int key) => Math.Abs(key) % SIZE;

    /// <summary>
    /// Adds a key to the hash set.
    /// </summary>
    /// <param name="key">The integer key to add.</param>
    public void Add(int key)
    {
        int idx = Hash(key);
        if (!_buckets[idx].Contains(key))
            _buckets[idx].AddLast(key);
    }

    /// <summary>
    /// Removes a key from the hash set.
    /// </summary>
    /// <param name="key">The integer key to remove.</param>
    public void Remove(int key)
    {
        int idx = Hash(key);
        _buckets[idx].Remove(key);
    }

    /// <summary>
    /// Determines whether the hash set contains the specified key.
    /// </summary>
    /// <param name="key">The integer key to locate.</param>
    /// <returns><c>true</c> if the key is found; otherwise, <c>false</c>.</returns>
    public bool Contains(int key)
    {
        int idx = Hash(key);
        return _buckets[idx].Contains(key);
    }
}
