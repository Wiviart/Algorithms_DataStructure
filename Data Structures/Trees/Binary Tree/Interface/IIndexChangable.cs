public interface IIndexChangable<T>
{
    void ChangeAt(int index, T value);
}