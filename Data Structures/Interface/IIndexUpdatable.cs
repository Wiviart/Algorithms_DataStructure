public interface IIndexUpdatable<T>
{
    void UpdateAt(int index, string value, T type);
}