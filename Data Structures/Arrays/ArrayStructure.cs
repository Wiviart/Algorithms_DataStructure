public class ArrayStructure : IStructure
{
    string[] array = [];

    public void Create(int size)
    {
        ArrayCreator creator = new ArrayCreator();
        array = creator.Create(size);
    }

    public void Read()
    {
        ArrayReader reader = new ArrayReader();
        string s = $"{array.Length} elements: {reader.Read(array)}";
        Console.WriteLine(s);
    }

    public void DeleteAt(int v)
    {
        if (v < 0 || v >= array.Length)
        {
            Console.WriteLine($"Index {v} is out of bounds");
            return;
        }

        string[] newArray = new string[array.Length - 1];

        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i == v)
            {
                Console.WriteLine($"Deleted {array[i]} at index {v}");
                continue;
            }

            newArray[j] = array[i];
            j++;
        }

        array = newArray;
    }

    public void Delete(string v)
    {
        ArrayDeleter deleter = new ArrayDeleter();
        array = deleter.Delete(array, v);
    }

    public void Update(string v1, string v2)
    {
        ArrayChanger changer = new ArrayChanger();
        changer.Change(v1, v2, array);
    }

    public void UpdateAt(int i, string value)
    {
        if (i < 0 || i >= array.Length)
        {
            Console.WriteLine($"Index {i} is out of bounds");
            return;
        }

        Console.WriteLine($"Updated {array[i]} at index {i} to {value}");

        array[i] = value;
    }

    public bool Search(string v)
    {
        return Array.IndexOf(array, v) != -1;
    }

    public void InsertAt(int v, string v2)
    {
        if (v < 0 || v > array.Length)
        {
            Console.WriteLine($"Index {v} is out of bounds");
            return;
        }

        string[] newArray = new string[array.Length + 1];

        for (int i = 0, j = 0; i < newArray.Length; i++)
        {
            if (i == v)
            {
                newArray[i] = v2;
                Console.WriteLine($"Inserted {v2} at index {v}");
                continue;
            }

            newArray[i] = array[j];
            j++;
        }

        array = newArray;
    }
}
