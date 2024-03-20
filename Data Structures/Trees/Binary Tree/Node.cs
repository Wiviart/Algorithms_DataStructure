public class Node(string value)
{
    string value = value;
    Node? left = null;
    Node? right = null;
    public string Value
    {
        get => value;
        set => this.value = value;
    }
    public Node? Left
    {
        get => left;
        set => left = value;
    }
    public Node? Right
    {
        get => right;
        set => right = value;
    }
}