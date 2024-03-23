public class Graph
{
    List<Vertex> vertices = new List<Vertex>();
    public List<Vertex> Vertices => vertices;
    List<Edge> edges = new List<Edge>();
    public List<Edge> Edges => edges;

    public bool Adjacent(int v, int w)
    {
        foreach (var item in edges)
        {
            if (item.Start == v && item.End == w)
                return true;
        }
        return false;
    }

    public List<int> Neighbors(int v)
    {
        List<int> neighbors = new List<int>();
        foreach (var item in edges)
        {
            if (item.Start == v)
                neighbors.Add(item.End);
        }
        return neighbors;
    }

    public void AddEdge(int v, int w)
    {
        if (Adjacent(v, w))
            return;
        edges.Add(new Edge(v, w));
        edges.Add(new Edge(w, v));
    }

    public void AddVertex(string v)
    {
        vertices.Add(new Vertex(v));
    }

    public string GetVertexValue(int v)
    {
        if (v < 0 || v >= vertices.Count)
            return string.Empty;
        return vertices.ElementAt(v).Value;
    }

    public void RemoveVertex(int v)
    {
        if (v < 0 || v >= vertices.Count)
            return;

        vertices.RemoveAt(v);

        for (int i = 0; i < edges.Count; i++)
        {
            if (edges[i].Start == v || edges[i].End == v)
            {
                edges.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < edges.Count; i++)
        {
            if (edges[i].Start > v)
                edges[i].MinusVertex(0);
            if (edges[i].End > v)
                edges[i].MinusVertex(1);
        }
    }

    internal void InsertVertex(int index, string value)
    {
        List<Vertex> newVertices = new List<Vertex>();

        for (int i = 0; i < vertices.Count; i++)
        {
            if (i == index)
            {
                newVertices.Add(new Vertex(value));

                for (int j = 0; j < edges.Count; j++)
                {
                    if (edges[j].Start >= index)
                        edges[j].PlusVertex(0);
                    if (edges[j].End >= index)
                        edges[j].PlusVertex(1);
                }

                Random rnd = new Random();
                int t = rnd.Next(1, 5);
                for (int j = 0; j < t; j++)
                {
                    int r = rnd.Next(0, vertices.Count - 1);
                    AddEdge(index, r);
                }
            }

            newVertices.Add(vertices[i]);
        }

        vertices = newVertices;
    }

    internal bool Search(string v)
    {
        foreach (var item in vertices)
        {
            if (item.Value == v)
                return true;
        }
        return false;
    }
}