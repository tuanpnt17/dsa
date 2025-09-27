namespace DataStructures.ArrayAndHashing;

/// <summary>
/// Implements a simple hash map for integer keys and values using separate chaining.
/// </summary>
public class MyHashMap
{
    /// <summary>
    /// The number of buckets in the hash map. A prime number is used for better distribution.
    /// </summary>
    private const int SIZE = 1009;

    /// <summary>
    /// The array of buckets, each a linked list of key-value pairs to handle collisions.
    /// </summary>
    private readonly LinkedList<(int key, int value)>[] _buckets;

    /// <summary>
    /// Initializes a new instance of the <see cref="MyHashMap"/> class.
    /// </summary>
    public MyHashMap()
    {
        _buckets = new LinkedList<(int, int)>[SIZE];
        for (int i = 0; i < SIZE; i++)
            _buckets[i] = new LinkedList<(int, int)>();
    }

    /// <summary>
    /// Computes the hash code for the given key.
    /// </summary>
    /// <param name="key">The integer key to hash.</param>
    /// <returns>The index of the bucket for the key.</returns>
    private static int Hash(int key) => Math.Abs(key) % SIZE;

    /// <summary>
    /// Inserts a (key, value) pair into the hash map. If the key already exists, updates its value.
    /// </summary>
    /// <param name="key">The key to insert.</param>
    /// <param name="value">The value to associate with the key.</param>
    public void Put(int key, int value)
    {
        int idx = Hash(key);
        var bucket = _buckets[idx];
        var node = bucket.First;
        while (node != null)
        {
            if (node.Value.key == key)
            {
                node.Value = (key, value);
                return;
            }
            node = node.Next;
        }
        bucket.AddLast((key, value));
    }

    /// <summary>
    /// Gets the value associated with the specified key.
    /// </summary>
    /// <param name="key">The key to look up.</param>
    /// <returns>The value if found; otherwise, -1.</returns>
    public int Get(int key)
    {
        int idx = Hash(key);
        foreach (var (k, v) in _buckets[idx])
        {
            if (k == key)
                return v;
        }
        return -1;
    }

    /// <summary>
    /// Removes the mapping for the specified key if it exists.
    /// </summary>
    /// <param name="key">The key to remove.</param>
    public void Remove(int key)
    {
        int idx = Hash(key);
        var bucket = _buckets[idx];
        var node = bucket.First;
        while (node != null)
        {
            if (node.Value.key == key)
            {
                bucket.Remove(node);
                return;
            }
            node = node.Next;
        }
    }
}
