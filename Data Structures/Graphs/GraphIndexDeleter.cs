public class GraphIndexDeleter : IIndexDeletable<Graph>
{
    public void DeleteAt(Graph? graph, int index)
    {
        if (graph == null) return;

        if (index < 0 || index >= graph.Vertices.Count)
        {
            Console.WriteLine("Index out of range");
            return;
        }

        Console.WriteLine("Deleted vertex: " + graph.Vertices[index].Value + " at index: " + index);
        graph.RemoveVertex(index);
    }
}