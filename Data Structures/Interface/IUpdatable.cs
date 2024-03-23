public interface IUpdatable<T>
{
    void Update(string oldValue, string newValue, T? root = default);
}