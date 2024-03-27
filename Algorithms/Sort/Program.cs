int[] arr = [64, 34, 25, 12, 22, 11, 90, 44, 50, 15, 36
//  78, 85, 55, 47, 30, 65, 88, 1, 37, 42, 29, 17, 10, 32, 23, 24, 46, 14, 18, 19, 43, 49, 66, 88, 77, 55
];

Printer.Print(arr);

Console.WriteLine("0. Bubble Sort");
Console.WriteLine("1. Insertion Sort");
Console.WriteLine("2. Merge Sort");
Console.WriteLine("3. Selection Sort");
Console.WriteLine("4. Quick Sort");
Console.WriteLine("5. Tim Sort");
Console.WriteLine("6. Heap Sort");
Console.WriteLine("Select sort algorithm:");

int choice = 0;
int.TryParse(Console.ReadLine(), out choice);
ISort sort = SortFactory.GetSort(choice);
sort.Sort(arr);

Printer.Print(arr);