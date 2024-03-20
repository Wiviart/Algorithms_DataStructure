
public class FunctionLibrary
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        for (int i = 3; i <= MathF.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static string GetPrimeNumber(int max)
    {
        string primes = "";

        for (int i = 2; i < max; i++)
        {
            if (IsPrime(i))
            {
                primes += i;

                if (i < max - 1) primes += " ";
            }
        }

        return primes;
    }
}