using System.Collections;

public class DepthFirstReader : IReadable<string[], Node>
{
    public string[] Read(Node? root)
    {
        if (root == null) return [];

        string[] result = [];
        Stack<Node> stack = new Stack<Node>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            var x = current.Value + "[" + current.Left?.Value + ":" + current.Right?.Value + "]";
            result = [x, .. result];

            if (current.Left != null)
                stack.Push(current.Left);

            if (current.Right != null)
                stack.Push(current.Right);
        }

        return result.ToArray();
    }

    public string[] Print_2(Node root)
    {
        if (root == null) return [];

        string[] result = [root.Value];
        string[] leftValues = [];
        if (root.Left != null)
            leftValues = Print_2(root.Left);
        string[] rightValues = [];
        if (root.Right != null)
            rightValues = Print_2(root.Right);
        return [.. result, .. leftValues, .. rightValues];
    }
}