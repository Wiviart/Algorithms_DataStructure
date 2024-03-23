public class GraphDeleter : IDeletable<int, Graph, string>
{
    public int Delete(Graph? graph, string value)
    {
        if (graph == null) return 0;

        for (int i = 0; i < graph.Vertices.Count; i++)
        {
            if (graph.Vertices[i].Value == value)
            {
                graph.RemoveVertex(i);
                Console.WriteLine("Deleted vertex: " + value);
                break;
            }
        }

        return 0;
    }
}