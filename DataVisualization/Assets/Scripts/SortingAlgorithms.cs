// Algorithm taken from geeksforgeeks.com
using System;
using UnityEngine;
using System.Text;
using System.IO;


public class NewBehaviourScript : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        // One by one move boundary of unsorted subarray 
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array 
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;

            // Swap the found minimum element with the first 
            // element 
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }

    int Partition(int[] arr, int low,
                               int high)
    {
        int pivot = arr[high];

        // index of smaller element 
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            // If current element is smaller  
            // than the pivot 
            if (arr[j] < pivot)
            {
                i++;
                // swap arr[i] and arr[j] 
                arr[i] = arr[j];
                int temp = arr[i];
                arr[j] = temp;
            }
        }

        // swap arr[i+1] and arr[high] (or pivot) 
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }


    /* The main function that implements QuickSort() 
    arr[] --> Array to be sorted, 
    low --> Starting index, 
    high --> Ending index */
    void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {

            /* pi is partitioning index, arr[pi] is  
            now at right place */
            int pi = Partition(arr, low, high);

            // Recursively sort elements before 
            // partition and after partition 
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    int [] RandomArray(int length) {
        int numMin = 0;
        int numMax = 99;
        System.Random randNumber = new System.Random();
        int [] array = new int[length];
        foreach(int value in array) {
            randNumber.Next(numMin,numMax);
        }
        return array;
    }

    public static void Main() {
        var time = new System.Diagnostics.Stopwatch();
        String filePath = "";
        int count = 15;
        var dataCsv = new StringBuilder();
        

        for (int i = 0; i < count; i++){
            time.Restart(); // Reset time to 0 and start measuring
            time.Start();

            time.Stop();
        }
    

        File.WriteAllText(filePath,dataCsv.ToString());
    }
}