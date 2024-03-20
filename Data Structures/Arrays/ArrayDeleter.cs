public class ArrayDeleter : IDeletable<string[], string[], string>
{
    public string[] Delete(string[]? array, string value)
    {
        if (array == null)
        {
            Console.WriteLine("Array is empty");
            return array;
        }

        if (Array.IndexOf(array, value) == -1)
        {
            Console.WriteLine($"{value} not found");
            return array;
        }

        string[] newArray = new string[array.Length - 1];
        int j = 0;

        foreach (var item in array)
        {
            if (item == value)
            {
                Console.WriteLine($"Deleted {item}");
                continue;
            }

            newArray[j] = item;
            j++;
        }

        return newArray;
    }
}