public interface IIndexDeletable<T>
{
    void DeleteAt(T type, int index);
}