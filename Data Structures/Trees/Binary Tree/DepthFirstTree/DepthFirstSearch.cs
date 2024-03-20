using System.Collections;

public class DepthFirstSearch : ISearchable<Node>
{
    public bool Search(Node? root, string value)
    {
        if (root == null) return false;

        Stack<Node> stack = new Stack<Node>();

        stack.Push(root);

        while (stack.Count > 0)
        {
            var current = stack.Pop();

            if (current.Value == value)
                return true;

            if (current.Left != null)
                stack.Push(current.Left);

            if (current.Right != null)
                stack.Push(current.Right);
        }

        return false;
    }
}