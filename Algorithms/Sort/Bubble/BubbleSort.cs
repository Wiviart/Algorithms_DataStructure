public class BubbleSort : ISort
{
    public void Sort(int[] arr)
    {
        // NormalFunction(arr);
        RecursiveFunction(arr, arr.Length - 1);
    }

    public void NormalFunction(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(ref arr[j], ref arr[j + 1]);

                    Printer.Print(arr, arr[j + 1]);
                    Thread.Sleep(500);
                }
            }
        }
    }

    void RecursiveFunction(int[] arr, int length)
    {
        for (int i = 0; i < length; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                Swap(ref arr[i], ref arr[i + 1]);
                Printer.Print(arr, arr[i + 1]);
                Thread.Sleep(500);
            }
        }
        length--;
        if (length > 1)
        {
            RecursiveFunction(arr, length);
        }
    }

    void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}