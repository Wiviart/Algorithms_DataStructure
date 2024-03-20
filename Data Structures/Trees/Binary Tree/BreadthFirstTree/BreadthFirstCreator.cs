public class BreadthFirstCreator : ICreatable<Node, string[]>
{
    public Node Create(string[] s)
    {
        List<Node> nodes = new List<Node>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == "") continue;

            Node node = new Node(s[i]);
            nodes.Add(node);
        }

        for (int i = 0; i < nodes.Count; i++)
        {
            int leftIndex = 2 * i + 1;
            int rightIndex = 2 * i + 2;

            nodes[i].Left = leftIndex < nodes.Count ? nodes[leftIndex] : null;
            nodes[i].Right = rightIndex < nodes.Count ? nodes[rightIndex] : null;
        }

        return nodes[0];
    }
}