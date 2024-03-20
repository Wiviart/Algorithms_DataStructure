using System.Collections.Generic;

public class LinkedListStructure : IStructure
{
    LinkedList<string> linkedList = [];

    public void Create(int size)
    {
        string[] s = FunctionLibrary.GetPrimeNumber(size).Split(' ');
        linkedList = new LinkedList<string>(s);
    }

    public void Delete(string v)
    {
        LinkedListNode<string>? currentNode = linkedList.First;

        while (currentNode != null)
        {
            LinkedListNode<string>? nextNode = currentNode.Next;

            if (currentNode.Value == v)
            {
                linkedList.Remove(currentNode);
                Console.WriteLine($"Deleted {v}");
                break;
            }

            currentNode = nextNode;
        }
    }

    public void DeleteAt(int v)
    {
        if (v < 0 || v >= linkedList.Count)
        {
            Console.WriteLine($"Index {v} is out of bounds");
            return;
        }

        LinkedListNode<string>? currentNode = linkedList.First;

        for (int i = 0; i < linkedList.Count; i++)
        {
            if (currentNode == null) break;

            if (i == v)
            {
                linkedList.Remove(currentNode);
                Console.WriteLine($"Deleted {currentNode.Value} at index {i}");
                break;
            }

            currentNode = currentNode.Next;
        }
    }

    public void InsertAt(int v, string v2)
    {
        if (v < 0 || v >= linkedList.Count)
        {
            Console.WriteLine($"Index {v} is out of bounds");
            return;
        }

        LinkedListNode<string>? currentNode = linkedList.First;

        for (int i = 0; i < linkedList.Count; i++)
        {
            if (currentNode == null) break;

            if (i == v)
            {
                linkedList.AddBefore(currentNode, v2);
                Console.WriteLine($"Inserted {v2} at index {i}");
                break;
            }

            currentNode = currentNode.Next;
        }
    }

    public void Read()
    {
        string s = $"{linkedList.Count} elements: {string.Join(" ", linkedList)}";

        Console.WriteLine(s);
    }

    public bool Search(string v)
    {
        return linkedList.Contains(v);
    }

    public void Update(string v1, string v2)
    {
        LinkedListNode<string>? currentNode = linkedList.First;

        while (currentNode != null)
        {
            if (currentNode.Value == v1)
            {
                currentNode.Value = v2;
                Console.WriteLine($"Updated {v1} to {v2}");
            }
            currentNode = currentNode.Next;
        }
    }

    public void UpdateAt(int v1, string v2)
    {
        if (v1 < 0 || v1 >= linkedList.Count)
        {
            Console.WriteLine($"Index {v1} is out of bounds");
            return;
        }

        LinkedListNode<string>? currentNode = linkedList.First;

        for (int i = 0; i < linkedList.Count; i++)
        {
            if (currentNode == null) break;

            if (i == v1)
            {
                Console.WriteLine($"Updated {currentNode.Value} at index {i} to {v2}");
                currentNode.Value = v2;
                break;
            }

            currentNode = currentNode.Next;
        }
    }
    
}
