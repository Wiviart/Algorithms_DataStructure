public class Printer
{
    public static void Print(int[] arr)
    {
        Console.WriteLine("--------------------------");

        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("--------------------------");
    }

    public static void Print(int[] arr, int x)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == x)
                Console.Write($"[{arr[i]}] ");
            else
                Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}