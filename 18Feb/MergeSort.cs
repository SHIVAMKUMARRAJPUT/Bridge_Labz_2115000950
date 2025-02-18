using System;

class MergeSort{
    public static void sort(){
        int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 14 };
        foreach (var item in arr){
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Msort(0, arr.Length - 1, arr);
        foreach (var item in arr){
            Console.Write(item + " ");
        }

    }
    public static void Msort(int st, int end, int[] arr){
        if (st >= end) return;
        int mid = st + (end - st) / 2;
        Msort(st, mid, arr);
        Msort(mid + 1, end, arr);
        Merge(st, mid, end, arr);
    }
    public static void Merge(int st, int mid, int end, int[] arr){
        int m = mid - st + 1;
        int n = end - mid;
        int[] arr1 = new int[m];
        int[] arr2 = new int[n];

        for (int i = 0; i < m; i++){
            arr1[i] = arr[st + i];
        }
        for (int i = 0; i < n; i++){
            arr2[i] = arr[mid + i + 1];
        }

        int x = 0, y = 0, k = st;
        while (x < m && y < n){
            if (arr1[x] < arr2[y]){
                arr[k++] = arr1[x++];
            } else {
                arr[k++] = arr2[y++];
            }
        }

        while (x < m){
            arr[k++] = arr1[x++];
        }
        while (y < n){
            arr[k++] = arr2[y++];
        }
    }
}