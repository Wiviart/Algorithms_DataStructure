public class SelectionSort : ISort
{
    public void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            Swap(ref arr[i], ref arr[minIndex]);
            Printer.Print(arr, arr[i]);
            Thread.Sleep(500);
        }
    }

    void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}