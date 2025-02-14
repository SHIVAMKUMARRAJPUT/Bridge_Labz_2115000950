using System;

class SortingAlgorithms
{
    // Bubble Sort
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
    }

    // Selection Sort
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[minIdx])
                    minIdx = j;
            (arr[i], arr[minIdx]) = (arr[minIdx], arr[i]);
        }
    }

    // Insertion Sort
    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
                arr[j + 1] = arr[j--];
            arr[j + 1] = key;
        }
    }

    // Merge Sort
    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    public static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1, n2 = right - mid;
        int[] leftArr = new int[n1], rightArr = new int[n2];
        Array.Copy(arr, left, leftArr, 0, n1);
        Array.Copy(arr, mid + 1, rightArr, 0, n2);

        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
            arr[k++] = leftArr[i] <= rightArr[j] ? leftArr[i++] : rightArr[j++];
        while (i < n1) arr[k++] = leftArr[i++];
        while (j < n2) arr[k++] = rightArr[j++];
    }

    // Quick Sort
    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    public static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high], i = low - 1;
        for (int j = low; j < high; j++)
            if (arr[j] < pivot)
                (arr[++i], arr[j]) = (arr[j], arr[i]);
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }
}

class Test
{
    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }

    public static void Print()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original Array:");
        PrintArray(arr);

        int[] arr1 = (int[])arr.Clone();
        SortingAlgorithms.BubbleSort(arr1);
        Console.WriteLine("Bubble Sort:");
        PrintArray(arr1);

        int[] arr2 = (int[])arr.Clone();
        SortingAlgorithms.SelectionSort(arr2);
        Console.WriteLine("Selection Sort:");
        PrintArray(arr2);

        int[] arr3 = (int[])arr.Clone();
        SortingAlgorithms.InsertionSort(arr3);
        Console.WriteLine("Insertion Sort:");
        PrintArray(arr3);

        int[] arr4 = (int[])arr.Clone();
        SortingAlgorithms.MergeSort(arr4, 0, arr4.Length - 1);
        Console.WriteLine("Merge Sort:");
        PrintArray(arr4);

        int[] arr5 = (int[])arr.Clone();
        SortingAlgorithms.QuickSort(arr5, 0, arr5.Length - 1);
        Console.WriteLine("Quick Sort:");
        PrintArray(arr5);
    }
}