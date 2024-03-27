public class BinarySearch : ISearch
{
    public int Search(int[] arr, int target)
    {
        return SearchBinary(arr, 0, arr.Length - 1, target);
    }

    int SearchBinary(int[] arr, int low, int high, int target)
    {
        if (low > high)
            return -1;

        int mid = low + (high - low) / 2;

        if (arr[mid] == target)
            return mid;

        if (arr[mid] < target)
            return SearchBinary(arr, mid + 1, high, target);

        return SearchBinary(arr, low, mid - 1, target);
    }
}