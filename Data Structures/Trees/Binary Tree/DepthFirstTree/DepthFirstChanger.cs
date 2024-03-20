public class DepthFirstChanger : IChangable<Node>
{
    public void Change(string oldValue, string newValue, Node? root = default)
    {
        if (root == null) return;

        Stack<Node> stack = new Stack<Node>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var current = stack.Pop();

            if (current.Value == oldValue)
            {
                current.Value = newValue;
                Console.WriteLine($"Updated {oldValue} to {newValue}");
                return;
            }

            if (current.Left != null)
                stack.Push(current.Left);

            if (current.Right != null)
                stack.Push(current.Right);
        }
    }
}