public interface IChangable<T>
{
    void Change(string oldValue, string newValue, T? root = default);
}