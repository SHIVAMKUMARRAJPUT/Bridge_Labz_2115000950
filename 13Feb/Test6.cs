using System;

class Node6
{
    public int Key;
    public int Value;
    public Node6 Next;

    public Node6(int key, int value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}

class MyHashMap
{
    private const int Size = 100; // Fixed size for simplicity
    private Node6[] buckets;

    public MyHashMap()
    {
        buckets = new Node6[Size];
    }

    private int GetBucketIndex(int key)
    {
        return Math.Abs(key) % Size;
    }

    public void Put(int key, int value)
    {
        int index = GetBucketIndex(key);
        Node6 current = buckets[index];

        if (current == null)
        {
            buckets[index] = new Node6(key, value);
            return;
        }

        while (current != null)
        {
            if (current.Key == key)
            {
                current.Value = value; // Update value if key exists
                return;
            }
            if (current.Next == null) break;
            current = current.Next;
        }
        current.Next = new Node6(key, value);
    }

    public int Get(int key)
    {
        int index = GetBucketIndex(key);
        Node6 current = buckets[index];

        while (current != null)
        {
            if (current.Key == key)
                return current.Value;
            current = current.Next;
        }
        Console.WriteLine("Key not found");
        return -1;
    }

    public void Remove(int key)
    {
        int index = GetBucketIndex(key);
        Node6 current = buckets[index];
        Node6 prev = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (prev == null)
                    buckets[index] = current.Next;
                else
                    prev.Next = current.Next;
                return;
            }
            prev = current;
            current = current.Next;
        }
    }

    public bool ContainsKey(int key)
    {
        int index = GetBucketIndex(key);
        Node6 current = buckets[index];

        while (current != null)
        {
            if (current.Key == key)
                return true;
            current = current.Next;
        }
        return false;
    }
}

class Test6
{
   public  static void Print()
    {
        MyHashMap map = new MyHashMap();
        map.Put(1, 100);
        map.Put(2, 200);
        map.Put(3, 300);
        Console.WriteLine(map.Get(1));  // Output: 100
        Console.WriteLine(map.ContainsKey(2)); // Output: True
        map.Remove(2);
        Console.WriteLine(map.ContainsKey(2)); // Output: False
    }
}
