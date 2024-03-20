public class QueueStructure : IStructure
{
    Queue<string> queue = [];

    public void Create(int size)
    {
        string[] s = FunctionLibrary.GetPrimeNumber(size).Split(' ');
        queue = new Queue<string>(s);
    }

    public void Delete(string v)
    {
        var tempQueue = new Queue<string>();

        while (queue.Count > 0)
        {
            string current = queue.Dequeue();

            if (current != v)
                tempQueue.Enqueue(current);
            else
                Console.WriteLine($"Deleted {v}");
        }

        queue = tempQueue;
    }

    public void DeleteAt(int v)
    {
        var tempQueue = new Queue<string>();

        for (int i = 0; i < v; i++)
        {
            tempQueue.Enqueue(queue.Dequeue());
        }

        var current = queue.Dequeue();
        Console.WriteLine($"Deleted {current} at index {v}");

        while (queue.Count > 0)
        {
            tempQueue.Enqueue(queue.Dequeue());
        }

        queue = tempQueue;
    }

    public void InsertAt(int v, string v2)
    {
        var tempQueue = new Queue<string>();

        for (int i = 0; i < v; i++)
        {
            tempQueue.Enqueue(queue.Dequeue());
        }

        Console.WriteLine($"Inserted {v2} at index {v}");
        tempQueue.Enqueue(v2);

        while (queue.Count > 0)
        {
            tempQueue.Enqueue(queue.Dequeue());
        }

        queue = tempQueue;
    }

    public void Read()
    {
        string s = $"{queue.Count} elements: {string.Join(" ", queue)}";

        Console.WriteLine(s);
    }

    public bool Search(string v)
    {
        return queue.Contains(v);
    }

    public void Update(string v1, string v2)
    {
        var tempQueue = new Queue<string>();

        while (queue.Count > 0)
        {
            string current = queue.Dequeue();

            if (current == v1)
            {
                Console.WriteLine($"Updated {v1} to {v2}");
                tempQueue.Enqueue(v2);
            }
            else
            {
                tempQueue.Enqueue(current);
            }
        }

        queue = tempQueue;
    }

    public void UpdateAt(int v1, string v2)
    {
        Queue<string> tempQueue = new Queue<string>();

        for (int i = 0; i < v1; i++)
        {
            tempQueue.Enqueue(queue.Dequeue());
        }

        string x = queue.Dequeue();
        Console.WriteLine($"Updated {x} to {v2} at index {v1}");
        tempQueue.Enqueue(v2);

        while (queue.Count > 0)
        {
            tempQueue.Enqueue(queue.Dequeue());
        }

        queue = tempQueue;
    }

}