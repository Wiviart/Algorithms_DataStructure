public interface IDeletable<T, U, M>
{
    T Delete(U? root, M value);
}