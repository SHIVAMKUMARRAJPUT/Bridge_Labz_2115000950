using System;

public class MyHashMap
{
    private const int Size = 1000; 
    private int[] keys;
    private string[] values;
    private bool[] occupied;

    public MyHashMap()
    {
        keys = new int[Size];
        values = new string[Size];
        occupied = new bool[Size];
    }

    private int GetBucketIndex(int key)
    {
        return Math.Abs(key) % Size;
    }

    public void Put(int key, string value)
    {
        int index = GetBucketIndex(key);

        while (occupied[index]) // Linear probing for collision handling
        {
            if (keys[index] == key)
            {
                values[index] = value; // Update existing key
                return;
            }
            index = (index + 1) % Size; // Move to the next index
        }

        keys[index] = key;
        values[index] = value;
        occupied[index] = true;
    }

    public string Get(int key)
    {
        int index = GetBucketIndex(key);

        while (occupied[index])
        {
            if (keys[index] == key)
            {
                return values[index];
            }
            index = (index + 1) % Size;
        }

        throw new Exception("Key not found.");
    }

    public void Remove(int key)
    {
        int index = GetBucketIndex(key);

        while (occupied[index])
        {
            if (keys[index] == key)
            {
                occupied[index] = false; // Mark as deleted
                return;
            }
            index = (index + 1) % Size;
        }
    }

    public bool ContainsKey(int key)
    {
        int index = GetBucketIndex(key);

        while (occupied[index])
        {
            if (keys[index] == key)
            {
                return true;
            }
            index = (index + 1) % Size;
        }
        return false;
    }
}

class Test9
{
    public static void Print()
    {
        MyHashMap map = new MyHashMap();
        map.Put(1, "One");
        map.Put(2, "Two");
        map.Put(3, "Three");
        
        Console.WriteLine(map.Get(1)); // Output: One
        Console.WriteLine(map.ContainsKey(2)); // Output: True
        
        map.Remove(2);
        
        Console.WriteLine(map.ContainsKey(2)); // Output: False
    }
}


