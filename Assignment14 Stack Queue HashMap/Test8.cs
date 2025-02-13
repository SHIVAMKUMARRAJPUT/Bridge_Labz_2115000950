using System;

class HasMap{
    private const int Size = 1000; 
    private int[] keys;
    private bool[] occupied;

    public HasMap(){
        keys = new int[Size];
        occupied = new bool[Size];
    }

    private int GetBucketIndex(int key){
        return Math.Abs(key) % Size;
    }

    public void Put(int key){
        int index = GetBucketIndex(key);
        
        while (occupied[index]){
            if (keys[index] == key)
                return; 
            
            index = (index + 1) % Size;
        }

        keys[index] = key;
        occupied[index] = true;
    }

    public bool Contains(int key){
        int index = GetBucketIndex(key);

        while (occupied[index]){
            if (keys[index] == key)
                return true;

            index = (index + 1) % Size;
        }
        return false;
    }
}

class LongestConsecutiveSequence{
    public int FindLongestConsecutiveSequence(int[] nums){
        if (nums.Length == 0) return 0;

     HasMap map = new HasMap();
        for (int i = 0; i < nums.Length; i++){
            map.Put(nums[i]);
        }

        int maxLength = 0;
        for (int i = 0; i < nums.Length; i++){
            if (!map.Contains(nums[i] - 1)){
                int currentNum = nums[i];
                int currentLength = 1;

                while (map.Contains(currentNum + 1)){
                    currentNum++;
                    currentLength++;
                }

                maxLength = Math.Max(maxLength, currentLength);
            }
        }

        return maxLength;
    }
}

class Test8{
    public static void Print(){
        LongestConsecutiveSequence finder = new LongestConsecutiveSequence();
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        int result = finder.FindLongestConsecutiveSequence(nums);
        Console.WriteLine(result); 
    }
}
