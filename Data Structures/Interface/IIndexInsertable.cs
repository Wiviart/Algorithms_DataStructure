public interface IIndexInsertable<T, U>
{
    void InsertAt(int index, T value, U type);
}