using System;
using System.Collections;
using System.Collections.Generic;

public class StackStructure : IStructure
{
    Stack<string> stack = [];

    public void Create(int size)
    {
        string[] s = FunctionLibrary.GetPrimeNumber(size).Split(' ');
        Array.Reverse(s);
        stack = new Stack<string>(s);
    }

    public void Delete(string v)
    {
        Stack<string> tempStack = new Stack<string>();

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (current == v)
            {
                Console.WriteLine($"Deleted {v}");
                break;
            }

            tempStack.Push(current);
        }

        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }
    }

    public void DeleteAt(int v)
    {
        Stack<string> tempStack = new Stack<string>();

        for (int i = 0; i < v; i++)
        {
            tempStack.Push(stack.Pop());
        }

        string x = stack.Pop();
        Console.WriteLine($"Deleted {x} at index {v}");

        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }
    }

    public void InsertAt(int v, string v2)
    {
        Stack<string> tempStack = new Stack<string>();

        for (int i = 0; i < v; i++)
        {
            tempStack.Push(stack.Pop());
        }

        stack.Push(v2);
        Console.WriteLine($"Inserted {v2} at index {v}");

        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }
    }

    public void Read()
    {
        string s = $"{stack.Count} elements: {string.Join(" ", stack)}";

        Console.WriteLine(s);
    }

    public bool Search(string v)
    {
        Stack<string> tempStack = new Stack<string>();

        bool result = false;
        
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (current == v)
            {
                stack.Push(current);
                result = true;
                break;
            }

            tempStack.Push(current);
        }

        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }

        return result;
    }

    public void Update(string v1, string v2)
    {
        Stack<string> tempStack = new Stack<string>();

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (current == v1)
            {
                stack.Push(v2);
                Console.WriteLine($"Updated {v1} to {v2}");
                break;
            }

            tempStack.Push(current);
        }

        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }
    }

    public void UpdateAt(int v1, string v2)
    {
        Stack<string> tempStack = new Stack<string>(stack.Count);

        for (int i = 0; i < v1; i++)
        {
            tempStack.Push(stack.Pop());
        }

        string x = stack.Pop();
        Console.WriteLine($"Updated {x} at index {v1} to {v2}");
        stack.Push(v2);

        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }
    }
    
}
