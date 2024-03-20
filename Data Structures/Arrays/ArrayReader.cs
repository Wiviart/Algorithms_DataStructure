public class ArrayReader : IReadable<string, string[]>
{
    public string Read(string[]? array)
    {
        if (array == null) return "";

        return string.Join(" ", array);
    }
}