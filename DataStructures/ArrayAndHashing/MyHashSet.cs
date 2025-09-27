namespace DataStructures.ArrayAndHashing;

public class MyHashSet
{
    private const int SIZE = 1009; // A prime number for better distribution
    private readonly LinkedList<int>[] _buckets;

    public MyHashSet()
    {
        _buckets = new LinkedList<int>[SIZE];
        for (int i = 0; i < SIZE; i++)
            _buckets[i] = new LinkedList<int>();
    }

    private static int Hash(int key) => Math.Abs(key) % SIZE;

    public void Add(int key)
    {
        int idx = Hash(key);
        if (!_buckets[idx].Contains(key))
            _buckets[idx].AddLast(key);
    }

    public void Remove(int key)
    {
        int idx = Hash(key);
        _buckets[idx].Remove(key);
    }

    public bool Contains(int key)
    {
        int idx = Hash(key);
        return _buckets[idx].Contains(key);
    }
}
