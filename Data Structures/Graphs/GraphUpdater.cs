public class GraphUpdater : IUpdatable<Graph>
{
    public void Update(string oldValue, string newValue, Graph? graph = null)
    {
        if (graph == null) return;

        foreach (var item in graph.Vertices)
        {
            if (item.Value == oldValue)
            {
                item.Value = newValue;
                Console.WriteLine($"Updated vertex {oldValue} to: {newValue}");
                break;
            }
        }
    }
}