public class ListStructure : IStructure
{
    List<string> list = [];

    public void Create(int size)
    {
        string s = FunctionLibrary.GetPrimeNumber(size);
        list = new List<string>(s.Split(' '));
    }

    public void Delete(string v)
    {
        if (Search(v))
        {
            Console.WriteLine($"Deleted {v}");
            list.Remove(v);
        }
        else
        {
            Console.WriteLine($"{v} not found");
        }
    }

    public void DeleteAt(int v)
    {
        if (v < 0 || v >= list.Count)
        {
            Console.WriteLine($"Index {v} is out of bounds");
            return;
        }

        Console.WriteLine($"Deleted {list[v]} at index {v}");
        list.RemoveAt(v);
    }

    public void InsertAt(int v, string v2)
    {
        if (v < 0 || v > list.Count)
        {
            Console.WriteLine($"Index {v} is out of bounds");
            return;
        }

        Console.WriteLine($"Inserted {v2} at index {v}");
        list.Insert(v, v2);
    }

    public void Read()
    {
        string s = $"{list.Count} elements: {string.Join(" ", list)}";
        Console.WriteLine(s);
    }

    public bool Search(string v)
    {
        return list.Contains(v);
    }

    public void Update(string v1, string v2)
    {
        if (list.Contains(v1))
        {
            int index = list.IndexOf(v1);
            list[index] = v2;
            Console.WriteLine($"Updated {v1} to {v2}");
        }
        else
        {
            Console.WriteLine($"{v1} not found");
        }
    }

    public void UpdateAt(int v1, string v2)
    {
        if (v1 < 0 || v1 >= list.Count)
        {
            Console.WriteLine($"Index {v1} is out of bounds");
            return;
        }

        Console.WriteLine($"Updated {list[v1]} at index {v1} to {v2}");
        list[v1] = v2;
    }
}