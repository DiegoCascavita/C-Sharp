using System;

class QuickSort {
    static void Main() {
        int[] arr = { 12, 4, 5, 6, 7, 3, 1, 15 };
        Console.WriteLine("Original array: " + string.Join(", ", arr));

        QuickSortAlgorithm(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }

    static void QuickSortAlgorithm(int[] arr, int low, int high) {
        if (low < high) {
            int pivotIndex = Partition(arr, low, high);

            QuickSortAlgorithm(arr, low, pivotIndex - 1);
            QuickSortAlgorithm(arr, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high) {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++) {
            if (arr[j] <= pivot) {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);

        return i + 1;
    }

    static void Swap(int[] arr, int i, int j) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
