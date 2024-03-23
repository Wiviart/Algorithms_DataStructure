public class GraphIndexInserter : IIndexInsertable<string, Graph>
{
    public void InsertAt(int index, string value, Graph? graph)
    {
        if (graph == null) return;

        if (index < 0 || index >= graph.Vertices.Count)
        {
            Console.WriteLine("Index out of range");
            return;
        }

        Console.WriteLine("Inserted vertex: " + value + " at index: " + index);
        graph.InsertVertices(index, value);
    }
}