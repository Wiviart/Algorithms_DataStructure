public class GraphReader : IReadable<int, Graph>
{
    public int Read(Graph? graph)
    {
        if (graph == null) return 0;

        PrintGraphList(graph);
        // PrintGraphMatrix(graph);

        return 0;
    }

    public void PrintGraphList(Graph graph)
    {
        for (int i = 0; i < graph.Vertices.Count; i++)
        {
            Console.Write(i + "[" + graph.GetVertexValue(i) + "]");
            foreach (var item2 in graph.Neighbors(i))
            {
                Console.Write(" -> " + item2 + "[" + graph.GetVertexValue(item2) + "]");
            }
            Console.WriteLine();
        }
    }

    public void PrintGraphMatrix(Graph graph)
    {
        int[,] matrix = new int[graph.Vertices.Count, graph.Vertices.Count];
        for (int i = 0; i < graph.Vertices.Count; i++)
        {
            for (int j = 0; j < graph.Vertices.Count; j++)
            {
                matrix[i, j] = 0;
            }
        }

        foreach (var item in graph.Edges)
        {
            matrix[item.Start, item.End] = 1;
        }

        Console.Write("   ");
        for (int i = 0; i < graph.Vertices.Count; i++)
        {
            Console.Write((i < 10 ? " " : "") + i + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < graph.Vertices.Count; i++)
        {
            Console.Write((i < 10 ? " " : "") + i + " ");
            for (int j = 0; j < graph.Vertices.Count; j++)
            {
                Console.Write(" " + matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}