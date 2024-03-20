public interface ICreatable<T, U>
{
    T Create(U value);
}