public interface ISearchable<T>
{
    bool Search(T? root, string value);
}