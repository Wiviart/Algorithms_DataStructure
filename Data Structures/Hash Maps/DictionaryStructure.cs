using System.Collections.Generic;

public class DictionaryStructure : IStructure
{
    Dictionary<string, string> dictionary = [];

    public void Create(int size)
    {
        string[] primeNumbers = FunctionLibrary.GetPrimeNumber(size).Split(' ');
        dictionary = primeNumbers.ToDictionary(key => key, value => value);
    }

    public void Delete(string value)
    {
        var pair = dictionary.FirstOrDefault(x => x.Value == value);

        if (pair.Equals(default(KeyValuePair<string, string>)))
        {
            Console.WriteLine($"Value '{value}' not found in the dictionary!");
            return;
        }

        dictionary.Remove(pair.Key);
        Console.WriteLine($"Deleted {pair.Key} with value {pair.Value}");
    }

    public void DeleteAt(int i)
    {
        if (i < 0 || i >= dictionary.Count)
        {
            Console.WriteLine($"Index {i} is out of bounds");
            return;
        }

        var pair = dictionary.ElementAt(i);
        dictionary.Remove(pair.Key);

        Console.WriteLine($"Deleted {pair.Key} with value {pair.Value} at index {i}");
    }

    public void InsertAt(int v, string v2)
    {
        Console.WriteLine("InsertAt is not supported for Dictionary");
    }

    public void Read()
    {
        string s = $"{dictionary.Count} elements: {string.Join(" ", dictionary.Values)}";
        Console.WriteLine(s);
    }

    public bool Search(string v)
    {
        return dictionary.ContainsValue(v);
    }

    public void Update(string v1, string v2)
    {
        var pair = dictionary.FirstOrDefault(x => x.Value == v1);

        if (pair.Equals(default(KeyValuePair<string, string>)))
        {
            Console.WriteLine($"Value '{v1}' not found in the dictionary!");
            return;
        }

        dictionary[pair.Key] = v2;
        Console.WriteLine($"Updated {pair.Key} with value {pair.Value} to {v2}");
    }

    public void UpdateAt(int v1, string v2)
    {
        if (v1 < 0 || v1 >= dictionary.Count)
        {
            Console.WriteLine($"Index {v1} is out of bounds");
            return;
        }

        var pair = dictionary.ElementAt(v1);
        Console.WriteLine($"Updated {pair.Key} with value {pair.Value} at index {v1} to {v2}");
        dictionary[pair.Key] = v2;
    }

}