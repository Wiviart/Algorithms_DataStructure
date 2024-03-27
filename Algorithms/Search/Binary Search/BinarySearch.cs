public class BinarySearch : ISearch
{
    public int Search(int[] arr, int target)
    {
        return SearchBinaryRecursive(arr, 0, arr.Length - 1, target);
        // return SearchBinaryIterative(arr, 0, arr.Length - 1, target);
    }

    int SearchBinaryRecursive(int[] arr, int low, int high, int target)
    {
        if (low > high)
            return -1;

        int mid = low + (high - low) / 2;

        if (arr[mid] == target)
            return mid;

        if (arr[mid] < target)
            return SearchBinaryRecursive(arr, mid + 1, high, target);

        return SearchBinaryRecursive(arr, low, mid - 1, target);
    }

    int SearchBinaryIterative(int[] arr, int low, int high, int target)
    {
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }
}