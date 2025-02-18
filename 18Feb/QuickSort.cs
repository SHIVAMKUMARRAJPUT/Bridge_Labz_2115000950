using System;
using System.Collections.Concurrent;
using System.Globalization;
class QuickSort{
    public static void sort(){
        int []arr={9,8,7,6,6,53,2,4,5,4,3,2,1};
        foreach (var item in arr)
        {
            Console.Write(item +" ");   
        }
        Console.WriteLine();
        Quick(0,arr.Length-1,arr);
        foreach (var item in arr)
        {
            Console.Write(item +" ");   
        }
    }
    public static void Quick(int st,int end,int[]arr){
        if(st>=end)return;
        int pi=Partitioner(st,end,arr);
        Quick(st,pi-1,arr);
        Quick(pi+1,end,arr);
    }
    public static int Partitioner(int left ,int right,int[] arr){
        int pivot=arr[right];
        int i=left-1;
        int j;
        for(j=left;j<right;j++){
            if(arr[j]<pivot){
                i++;
                int temp=arr[i];
                arr[i]=arr[j];
                arr[j]=temp;
            }
        }
        int temp1 =arr[i+1];
        arr[i+1]=pivot;
        arr[right]=temp1;
        return i+1;
    }
}