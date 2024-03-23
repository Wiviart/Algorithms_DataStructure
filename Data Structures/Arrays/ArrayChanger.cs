public class ArrayChanger : IUpdatable<string[]>
{
    public void Update(string oldValue, string newValue, string[]? array = default)
    {
        if (array == null)
        {
            Console.WriteLine("Array is null");
            return;
        }

        int index = Array.IndexOf(array, oldValue);

        if (index == -1)
        {
            Console.WriteLine($"{oldValue} not found");
            return;
        }

        array[index] = newValue;
        Console.WriteLine($"Updated {oldValue} to {newValue}");
    }
}