using System;

class MyDeque
{
    private int[] deque;
    private int front, rear, size, capacity;

    public MyDeque(int capacity)
    {
        this.capacity = capacity;
        deque = new int[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void PushBack(int value)
    {
        if (size == capacity) return; // No overflow handling
        rear = (rear + 1) % capacity;
        deque[rear] = value;
        size++;
    }

    public void PopFront()
    {
        if (size == 0) return;
        front = (front + 1) % capacity;
        size--;
    }

    public int Front()
    {
        if (size == 0) return -1;
        return deque[front];
    }

    public int Back()
    {
        if (size == 0) return -1;
        return deque[rear];
    }

    public bool IsEmpty()
    {
        return size == 0;
    }
}

class SlidingWindowMax
{
    public static void FindMaxInWindows(int[] arr, int k)
    {
        int n = arr.Length;
        if (n == 0 || k == 0) return;

        MyDeque dq = new MyDeque(n);
        
        for (int i = 0; i < n; i++)
        {
            // Remove elements outside the window
            if (!dq.IsEmpty() && dq.Front() < i - k + 1)
            {
                dq.PopFront();
            }

            // Remove smaller elements as they are useless
            while (!dq.IsEmpty() && arr[dq.Back()] <= arr[i])
            {
                dq.PopFront();
            }

            dq.PushBack(i);

            // Print max when the window is filled
            if (i >= k - 1)
            {
                Console.Write(arr[dq.Front()] + " ");
            }
        }
    }
}

class Test4{
    public static void Print(){
        int[] arr = {1, 3, -1, -3, 5, 3, 6, 7};
        int k = 3;
        SlidingWindowMax.FindMaxInWindows(arr, k);
    }
}
