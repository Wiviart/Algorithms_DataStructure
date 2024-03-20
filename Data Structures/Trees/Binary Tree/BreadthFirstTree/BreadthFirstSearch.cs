using System.Collections;

public class BreadthFirstSearch : ISearchable<Node>
{
    public bool Search(Node? root, string value)
    {
        if (root == null) return false;

        Queue<Node> queue = new Queue<Node>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current.Value == value)
                return true;

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }

        return false;
    }
}