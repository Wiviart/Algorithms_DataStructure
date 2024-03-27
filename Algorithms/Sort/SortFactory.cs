public class SortFactory
{
    public static ISort GetSort(int i)
    {
        switch (i)
        {
            case 0:
                Console.WriteLine("Bubble Sort");
                return new BubbleSort();
            case 1:
                Console.WriteLine("Insertion Sort");
                return new InsertionSort();
            case 2:
                Console.WriteLine("Merge Sort");
                return new MergeSort();
            case 3:
                Console.WriteLine("Selection Sort");
                return new SelectionSort();
            case 4:
                Console.WriteLine("Quick Sort");
                return new QuickSort();
            case 5:
                Console.WriteLine("Tim Sort");
                return new TimSort();
            case 6:
                Console.WriteLine("Heap Sort");
                return new HeapSort();
            default:
                return new BubbleSort();
        }
    }
}