public class GraphIndexUpdater : IIndexUpdatable<Graph>
{
    public void UpdateAt(int index, string newValue, Graph? graph = null)
    {
        if (graph == null) return;

        if(index < 0 || index >= graph.Vertices.Count)
        {
            Console.WriteLine("Index out of range");
            return;
        }

        for (int i = 0; i < graph.Vertices.Count; i++)
        {
            if (i == index)
            {
                Console.WriteLine($"Updated vertex {graph.Vertices[i].Value} at index {index} to: {newValue}");
                graph.Vertices[i].Value = newValue;
                break;
            }
        }
    }
}