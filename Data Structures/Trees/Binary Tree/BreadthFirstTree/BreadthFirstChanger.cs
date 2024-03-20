public class BreadthFirstChanger : IChangable<Node>
{
    public void Change(string oldValue, string newValue, Node? root = default)
    {
        if (root == null) return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current.Value == oldValue)
            {
                current.Value = newValue;
                Console.WriteLine($"Updated {oldValue} to {newValue}");
                return;
            }

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }
}