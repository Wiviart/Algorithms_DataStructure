public class MergeSort : ISort
{
    public void Sort(int[] arr)
    {
        int n = arr.Length;
        if (n < 2)
            return;

        int mid = n / 2;
        int[] left = new int[mid];
        int[] right = new int[n - mid];

        for (int i = 0; i < mid; i++)
            left[i] = arr[i];
        for (int i = mid; i < n; i++)
            right[i - mid] = arr[i];

        Sort(left);
        Sort(right);

        Merge(arr, left, right);
    }

    private void Merge(int[] arr, int[] left, int[] right)
    {
        int nL = left.Length;
        int nR = right.Length;
        int i = 0, j = 0, k = 0;

        while (i < nL && j < nR)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < nL)
        {
            arr[k] = left[i];
            i++;
            k++;
        }

        while (j < nR)
        {
            arr[k] = right[j];
            j++;
            k++;
        }

        Printer.Print(arr);

        Thread.Sleep(500);
    }
}