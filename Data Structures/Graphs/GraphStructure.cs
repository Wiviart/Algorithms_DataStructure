public class GraphStructure : IStructure
{
    Graph graph = new Graph();

    public void Create(int size)
    {
        string[] s = FunctionLibrary.GetPrimeNumber(size).Split(' ');

        ICreatable<Graph, string[]> creator = new GraphCreator();
        graph = creator.Create(s);
    }

    public void Delete(string v)
    {
        IDeletable<int, Graph, string> deleter = new GraphDeleter();
        deleter.Delete(graph, v);
    }

    public void DeleteAt(int v)
    {
        IIndexDeletable<Graph> deleter = new GraphIndexDeleter();
        deleter.DeleteAt(graph, v);
    }

    public void InsertAt(int v, string v2)
    {
        IIndexInsertable<string, Graph> inserter = new GraphIndexInserter();
        inserter.InsertAt(v, v2, graph);
    }

    public void Read()
    {
        IReadable<int, Graph> reader = new GraphReader();
        reader.Read(graph);
    }

    public bool Search(string v)
    {
        return graph.Search(v);
    }

    public void Update(string v1, string v2)
    {
        IUpdatable<Graph> updater = new GraphUpdater();
        updater.Update(v1, v2, graph);
    }

    public void UpdateAt(int v1, string v2)
    {
        IIndexUpdatable<Graph> updater = new GraphIndexUpdater();
        updater.UpdateAt(v1, v2, graph);
    }
}