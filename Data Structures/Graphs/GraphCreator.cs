public class GraphCreator : ICreatable<Graph, string[]>
{
    public Graph Create(string[] s)
    {
        Graph graph = new Graph();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == "") continue;
            graph.AddVertex(s[i]);
        }

        for (int i = 0; i < graph.Vertices.Count; i++)
        {
            Random ra = new Random();
            int a = ra.Next(1, 2);
            for (int j = 0; j < a; j++)
            {
                int k = ra.Next(0, graph.Vertices.Count);
                if (i == k) continue;
                graph.AddEdge(i, k);
            }
        }

        return graph;
    }
}