public class DepthTreeStructure : IStructure
{
    Node? root;
    public void Create(int size)
    {
        string[] s = FunctionLibrary.GetPrimeNumber(size).Split(' ');

        ICreatable<Node, string[]> creator = new BreadthFirstCreator();
        root = creator.Create(s);
    }

    public bool Search(string v)
    {
        ISearchable<Node> searcher = new DepthFirstSearch();

        return searcher.Search(root, v);
    }

    public void InsertAt(int v, string v2)
    {
    }

    public void Delete(string v)
    {
        IDeletable<Node, Node, string> deleter = new DepthFirstDeleter();
        Node x = deleter.Delete(root, v);
        if (x != null) root = null;
    }

    public void DeleteAt(int v)
    {

    }

    public void Read()
    {
        IReadable<string[], Node> printer = new DepthFirstReader();
        string[] s = printer.Read(root);
        Console.WriteLine(string.Join(" ", s));
    }

    public void Update(string v1, string v2)
    {
        IChangable<Node> updater = new DepthFirstChanger();
        updater.Change(v1, v2, root);
    }

    public void UpdateAt(int v1, string v2)
    {

    }

}