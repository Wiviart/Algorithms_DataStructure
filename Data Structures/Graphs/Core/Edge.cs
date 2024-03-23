public class Edge
{
    int start;
    public int Start => start;
    int end;
    public int End => end;

    public int Weight;

    public Edge(int start, int end)
    {
        this.start = start;
        this.end = end;
    }

    public void MinusVertex(int index = 0)
    {
        if (index == 0)
            start--;
        else
            end--;
    }

    public void PlusVertex(int index = 0)
    {
        if (index == 0)
            start++;
        else
            end++;
    }
}