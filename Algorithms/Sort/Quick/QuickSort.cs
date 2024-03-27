
public class QuickSort : ISort
{
    public void Sort(int[] arr)
    {
        SortFunction(arr, 0, arr.Length - 1);
    }

    private void SortFunction(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            SortFunction(arr, low, pi - 1);
            SortFunction(arr, pi + 1, high);
        }
    }

    int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];

        int i = low - 1;

        for (int j = low; j <= high - 1; j++)
        {
            int x = arr[j];
            if (x < pivot)
            {
                i++;
                Swap(arr, i, j);

                Printer.Print(arr, arr[j]);
            }
        }

        Swap(arr, i + 1, high);

        Printer.Print(arr, arr[i + 1]);
        return i + 1;
    }

    void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}