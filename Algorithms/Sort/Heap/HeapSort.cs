public class HeapSort : ISort
{
    public void Sort(int[] arr)
    {
        int N = arr.Length;

        for (int i = N / 2 - 1; i >= 0; i--)
            Heapify(arr, N, i);

        for (int i = N - 1; i > 0; i--)
        {
            Swap(arr, 0, i);
            Heapify(arr, i, 0);
        }
    }

    void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;

        Printer.Print(arr, arr[j]);
    }

    void Heapify(int[] arr, int length, int root)
    {
        int largest = root; // Initialize largest as root
        int l = 2 * root + 1; // left = 2*i + 1
        int r = 2 * root + 2; // right = 2*i + 2

        if (l < length && arr[l] > arr[largest])
            largest = l;

        if (r < length && arr[r] > arr[largest])
            largest = r;

        if (largest != root)
        {
            Swap(arr, root, largest);
            Heapify(arr, length, largest);
        }
    }
}