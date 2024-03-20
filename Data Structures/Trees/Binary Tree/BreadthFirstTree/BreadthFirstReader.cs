using System.Collections;

public class BreadthFirstReader : IReadable<string[], Node>
{
    public string[] Read(Node? root)
    {
        string[] result = [];

        if (root == null) return result;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            var x = current.Value + "[" + current.Left?.Value + ":" + current.Right?.Value + "]";
            result = [.. result, x];

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }

        return result;
    }
}