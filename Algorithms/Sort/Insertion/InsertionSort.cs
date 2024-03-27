public class InsertionSort : ISort
{
    public void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            for (int j = i; j > 0; j--)
            {
                if (arr[j] < arr[j - 1])
                {
                    Swap(ref arr[j], ref arr[j - 1]);

                    Printer.Print(arr, arr[j]);
                    Thread.Sleep(500);
                }
            }
        }
    }

    void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}