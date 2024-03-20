using System.Collections.Generic;

public class HashSetStructure : IStructure
{
    HashSet<string> hashSet = [];

    public void Create(int size)
    {
        string[] s = FunctionLibrary.GetPrimeNumber(size).Split(' ');
        hashSet = new HashSet<string>(s);
    }

    public void Delete(string v)
    {
        if (hashSet.Remove(v))
            Console.WriteLine($"Deleted {v}");
        else
            Console.WriteLine($"{v} not found");
    }

    public void DeleteAt(int v)
    {
        Console.WriteLine("Can not implemented the delete with index in HashSet");
    }

    public void InsertAt(int v, string v2)
    {
        Console.WriteLine("Can not implemented the insert with index in HashSet");
    }

    public void Read()
    {
        string s = $"{hashSet.Count} elements: {string.Join(" ", hashSet)}";

        Console.WriteLine(s);
    }

    public void Update(string v1, string v2)
    {
        if (hashSet.Remove(v1))
        {
            hashSet.Add(v2);
            Console.WriteLine($"Updated {v1} to {v2}");
        }
        else
            Console.WriteLine($"{v1} not found");
    }

    public void UpdateAt(int v1, string v2)
    {
        Console.WriteLine("Can not implemented the update with index in HashSet");
    }

    public bool Search(string v)
    {
        return hashSet.Contains(v);
    }

}
