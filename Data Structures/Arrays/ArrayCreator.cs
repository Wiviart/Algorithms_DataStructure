public class ArrayCreator : ICreatable<string[], int>
{
    public string[] Create(int value)
    {
        string s = FunctionLibrary.GetPrimeNumber(value);
        string[] array = s.Split(' ');

        return array;
    }
}